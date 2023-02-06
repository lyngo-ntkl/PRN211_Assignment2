CREATE FUNCTION FN_UnitPrice(@Id int)
RETURNS money
AS
BEGIN
RETURN
	(SELECT UnitPrice FROM Product WHERE ProductId = @Id)
END
GO

--Th�m v�o table
ALTER TABLE dbo.Detail
ADD UnitPrice AS ([dbo].[FN_UnitPrice](ProductId))
GO