/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [name]
      ,[username]
      ,[password]
      ,[email]
  FROM [QuanLyThuVien].[dbo].[login]