USE [ProjectHR-02]
GO

/****** Object: SqlProcedure [dbo].[hrd_ResultManPower] Script Date: 8/23/2023 5:13:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[hrd_ResultManPower]
    @startDate date,
    @endDate date
AS
BEGIN


DECLARE @sql NVARCHAR(MAX);
SET @sql = '
    SELECT 
        CASE WHEN GROUPING(grup_name) = 1 THEN ''Grand Total''
             ELSE ISNULL(grup_name, ''Subtotal'') END as Nama_Grup,
             code_name,
             name_category';

DECLARE @columns NVARCHAR(MAX) = '';
DECLARE @subtotalColumns NVARCHAR(MAX) = ''; -- Kolom subtotals

DECLARE @currentDate DATE = @startDate;

WHILE @currentDate <= @endDate
BEGIN
    SET @columns += ',
        SUM(CASE WHEN DATEPART(MONTH, period) = ' + CAST(DATEPART(MONTH, @currentDate) AS NVARCHAR(2)) + ' AND DATEPART(YEAR, period) = ' + CAST(DATEPART(YEAR, @currentDate) AS NVARCHAR(4)) + ' THEN mp_total ELSE 0 END) AS ' + QUOTENAME(DATENAME(MONTH, @currentDate) + CAST(DATEPART(YEAR, @currentDate) AS NVARCHAR(4)));

    -- Tambahkan kolom subtotal pada setiap bulan
    SET @subtotalColumns += ',
        SUM(CASE WHEN DATEPART(MONTH, period) <= ' + CAST(DATEPART(MONTH, @currentDate) AS NVARCHAR(2)) + ' AND DATEPART(YEAR, period) <= ' + CAST(DATEPART(YEAR, @currentDate) AS NVARCHAR(4)) + ' THEN mp_total ELSE 0 END) AS Subtotal_' + CAST(DATEPART(MONTH, @currentDate) AS NVARCHAR(2)) + CAST(DATEPART(YEAR, @currentDate) AS NVARCHAR(4));

    SET @currentDate = DATEADD(MONTH, 1, @currentDate);
END

SET @sql += @columns;
SET @sql += @subtotalColumns; -- Tambahkan kolom subtotal ke dalam SELECT

SET @sql += '
    INTO #TempResult
    FROM tbl_mp
    WHERE period BETWEEN @startDate AND @endDate
    GROUP BY GROUPING SETS (
        (grup_name, code_name, name_category), 
        ()
    );

-- Retrieve the results from the temporary table
SELECT * FROM #TempResult
ORDER BY 
    CASE 
        WHEN Nama_Grup = ''Grand Total'' THEN 2
        ELSE 1
    END,
    code_name ASC,
    name_category ASC;

-- Drop the temporary table
DROP TABLE #TempResult;';

-- Menjalankan pernyataan SQL dinamis
EXEC sp_executesql @sql, N'@startDate DATE, @endDate DATE', @startDate, @endDate;

END;
