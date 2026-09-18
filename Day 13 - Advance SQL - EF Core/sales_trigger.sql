--Stock info table
CREATE TABLE [dbo].[stockInfo](
	[stockId] [int] NOT NULL,
	[stockName] [varchar](20) NULL,
	[stockPrice] [int] NULL,
	[availabeQty] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[stockId] ASC
)



--sales info
CREATE TABLE SalesInfo
(
    SalesId INT PRIMARY KEY,
    Pid INT NOT NULL,
    SaleQty INT NOT NULL,
    SaleTime DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_SalesInfo_StockInfo
        FOREIGN KEY (Pid)
        REFERENCES StockInfo
);

--this trigger will also work for bulk insert
CREATE TRIGGER trg_SalesInfo_UpdateStock
ON SalesInfo
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE S
    SET S.availabeQty = S.availabeQty - I.TotalSaleQty
    FROM StockInfo S
    INNER JOIN
    (
        SELECT Pid, SUM(SaleQty) AS TotalSaleQty
        FROM inserted
        GROUP BY Pid
    ) I
        ON S.stockId = I.Pid;
END;


select * from stockInfo
select * from SalesInfo

insert into SalesInfo values(901,5,12,GETDATE())