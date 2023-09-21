DECLARE @startDate DATE = '2023-08-01';
DECLARE @endDate DATE = '2023-09-30';
DECLARE @user INT = 1;

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
    WHERE period BETWEEN @startDate AND @endDate AND useridmp = @user
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
    name_category ASC,
    Nama_Grup ASC;

-- Drop the temporary table
DROP TABLE #TempResult;';

-- Menjalankan pernyataan SQL dinamis
EXEC sp_executesql @sql, N'@startDate DATE, @endDate DATE, @user INT', @startDate, @endDate,@user;
