SELECT TOP (1000)
	   [Id]
	  ,[Price]
      ,[StartDate]
      ,[EndDate]
      ,[Hotel_Id]
      ,[User_Id]
      ,[CreatedOn]
      ,[IsActive]
      ,[FirstName]
      ,[LastName]
      ,[Room_Id]
  FROM [BookingSystemDb].[dbo].[HotelsReservations]
  ORDER BY CreatedOn, StartDate
