CREATE TABLE [dbo].[Image_Tasks]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Task] IMAGE NOT NULL, 
    [Correct_Result] IMAGE NOT NULL, 
    [Filler_Image_1] IMAGE NOT NULL, 
    [Filler_image_2] IMAGE NOT NULL, 
    [Filler_Image_3] IMAGE NOT NULL,     
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id])
)
