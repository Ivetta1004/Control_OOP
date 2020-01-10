# Control_OOP
TASK:
Implement the program that parse string with some kind of file info info objects and output it grouped by categories and sorted by size.
Use classes & OOP principles.

## Input example:
	String text = @”Text:file.txt(6B);Some string content
	Image:img.bmp(19MB);1920х1080
	Text:data.txt(12B);Another string
	Text:data1.txt(7B);Yet another string
	Movie:logan.2017.mkv(19GB);1920х1080;2h12m”;

## Output example:
	Text files:
		file.txt
			Extension: txt
			Size: 6B
			Content: "Some string content"
		data1.txt
			Extension: txt
			Size: 7B
			Content: "Another string"
		data.txt
			Extension: txt
			Size: 12B
			Content: "Yet another string"
	Movies:
		logan.2017.mkv
			Extension: mkv
			Size: 19GB
			Resolution: 1920х1080
			Length: 2h12m
	Images:
		img.bmp
			Extension: bmp
			Size: 19MB
			Resolution: 1920х1080
