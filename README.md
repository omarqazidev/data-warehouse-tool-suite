# Data Warehouse Tool Suite
![image](https://user-images.githubusercontent.com/28197002/168483520-bb6d9ab2-79ff-4a33-a51d-66c022fe2df0.png)

## Tools: 
- Data Faker and Fabrication Tool
- Creator Fabricator Tool
- ETL (extract, transform, load) Tool
- Data Warehouse Analysis Tool (OLAP)

## Technologies:
- C#
- SQL

## Data Faker and Fabrication Tool
This is a C# tool in which I used Faker.NET, a port of the original Faker library/api. I did, however use Faker in very few places ie Names, Random Text. The rest of the times, I had to write custom C# code for multiple other fabrications, as Faker.NET doesn’t offer the full potential of the Faker API (PHP/Ruby).

![image](https://user-images.githubusercontent.com/28197002/168483382-197485ab-414a-41bc-b36a-2317cab11a7a.png)
![image](https://user-images.githubusercontent.com/28197002/168483385-f14c9f6f-e7ad-4869-8828-c73f8964ba28.png)
![image](https://user-images.githubusercontent.com/28197002/168483389-dda62abc-6707-41ff-af12-5271e0aa8cb4.png)

## Creator Fabricator Tool
This is a C# tool that I created that will allow you to create a database table, fabricate any database table, and create any data warehouse table.
The design and basic implementation of the software (the filled in textual data) is relating to this current project, so that I don’t have to copy and paste different data (creation queries, fabrication queries) from different places.

![image](https://user-images.githubusercontent.com/28197002/168483449-4fbd6b35-b6b9-430a-b00a-9932ec771422.png)
![image](https://user-images.githubusercontent.com/28197002/168483454-91c4d04f-8534-4fea-b56b-5a7319124743.png)

## ETL (extract, transform, load) Tool
This is a C# tool that I created that will allow you ETL (extract, transform, load) the school database into the school data warehouse (school_db, and school_dw respectively).
There’s a lot (quite a bit) more to this software than meets the eye. The code will be a better way to understand this piece of software than mere visuals.

![image](https://user-images.githubusercontent.com/28197002/168483476-23c79d14-8f22-402b-a477-8c0d955458ae.png)

## Data Warehouse Analysis Tool (OLAP)
This is a C# tool that I created that will allow you analyze the school data
warehouse.
<br>
With this tool you can:
- View data of any Data Warehouse Table
- Generate and Execute Query for any specific Data Warehouse Table
- Generate and Execute Query for joined Data Warehouse Tables
- Execute Custom Queries
- Save table data to excel file.

![image](https://user-images.githubusercontent.com/28197002/168483520-bb6d9ab2-79ff-4a33-a51d-66c022fe2df0.png)
![image](https://user-images.githubusercontent.com/28197002/168483523-fb7519a8-1788-4d67-b415-006c4dcdc527.png)
![image](https://user-images.githubusercontent.com/28197002/168483533-1ce00e6f-84c1-44ba-8275-df64ac58bca0.png)
![image](https://user-images.githubusercontent.com/28197002/168483544-8360eeaf-3739-4161-b981-b0fe26dfa53c.png)
![image](https://user-images.githubusercontent.com/28197002/168483548-09100104-d60c-4e4e-af75-dedf0483a1b8.png)
![image](https://user-images.githubusercontent.com/28197002/168483553-adb8ce65-5444-455c-bbd3-75fc4dc876ee.png)

## ERD - Entity Relationship Diagram
![image](https://user-images.githubusercontent.com/28197002/168483572-9bf6cf9f-27fc-4aaf-9128-fb13e807872c.png)

## Database Schema
![image](https://user-images.githubusercontent.com/28197002/168483593-8dac4b26-68dd-4a05-ac1a-bb59b741640a.png)


## Data Warehouse Schema -  Star Schema
I chose a star schema for my data warehouse schema as I believe, a star schema is more suitable for when you want to deal with less complexities when analyzing the data. The drawback of star schema is that there may be redundancy as it is a deformalized schema.
The project I was working on was not so big in size, as to make it difficult for the computer to handle data analysis. This is because I, myself, am the one fabricating the data, so the size of the data warehouse depends on me.
I wanted to make an analysis tool myself therefore I wanted a schema that had the least number of complexities and the least number of joins. Star schema was the perfect candidate

![image](https://user-images.githubusercontent.com/28197002/168483625-60f8fa31-e07f-4601-a687-8a0063ab53ae.png)

---

<h3 align="left">Connect with me:</h3>
<p align="left">
<a href="https://linkedin.com/in/omarqazidev" target="_blank"><img align="center" src="https://user-images.githubusercontent.com/28197002/168483094-a5bcd04a-8390-4d49-8a71-4bc0c648da54.png" alt="https://linkedin.com/in/omarqazidev" height="30" width="30" /></a>
<a href="https://twitter.com/omarqazidev" target="_blank"><img align="center" src="https://user-images.githubusercontent.com/28197002/168483020-654368df-acf9-4ce3-a46c-9cd6942856fd.png" alt="https://twitter.com/omarqazidev" height="30" width="30" /></a>
<a href="https://dev.to/omarqazidev" target="_blank"><img align="center" src="https://user-images.githubusercontent.com/28197002/172779487-098198e4-fdb6-4b27-aa10-12c5b22428eb.png" alt="omarqazidev" height="30" width="30" /></a>
<a href="mailto:omarqazidev@gmail.com" target="_blank"><img align="center" src="https://user-images.githubusercontent.com/28197002/168483231-a85ab431-b5f5-4ccc-afce-12d687e3451b.png" alt="omarqazidev" height="30" width="30" /></a>
</p>

