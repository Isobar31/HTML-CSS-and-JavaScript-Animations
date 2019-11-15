<?php
echo "<br /><br />";
    if (!(file_exists("E:\Sermon by DIV\Sermons\myFile2.txt")))
    {
        echo "File not exists";
    }
    else
    {
	    $fh = fopen("E:\Sermon by DIV\Sermons\myFile2.txt", 'r+') or die("Failed to open file");
	    $text = fgets($fh);
	    fseek($fh, 0, SEEK_END);
	    fwrite($fh, "$text") or die("Could not write to file");
	    fclose($fh);
	    echo "File 'E:\Sermon by DIV\Sermons\myFile2.txt' successfully updated";
    }
?>
