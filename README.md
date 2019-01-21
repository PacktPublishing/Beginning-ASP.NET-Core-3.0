# Beginning-ASP.NET-Core-3.0
This is the code repository for Beginning ASP.NET Core 3.0 [Video], by Packt Publishing. It contains all the supporting project files necessary to work through the video course from start to finish. 

About the Video Course
ASP.NET Core 3.0 is one of the fastest server-side web frameworks available. It provides developers with a robust, flexible and efficient tool to build amazing web apps and services. 
	This course will be thoroughly practical, focusing on getting started with ASP.NET Core 3.0 and the .NET Core 3.0 framework, and putting them into practice to build an amazing web application. This course will teach you the essentials for getting started in ASP.NET Core 3.0. You will learn to take advantage of the various features of the framework and work with the well-known code editor, Visual Studio Code.
By the end of the course, you will build your skills to meet the demands of modern-day application development and simplify modern back end web development with ASP.NET Core 3.0.


What You Will Learn
● Build secure, flexible, scalable & super-fast simple web applications and develop back-end with ASP.NET Core 3.0 to cater to business and customer needs.
● Develop the core skills needed to get started and build ASP.NET Core 3.0 applications.
● Design a database using the latest Entity Framework Core.
● Use Razor Pages to make coding page-focused scenarios easier and dynamic.
● Explore Visual Studio Code so that you can be as productive as possible.

Assumed Knowledge
To fully benefit from the coverage included in this course, you will need:
●	Prior working knowledge of C#
●	Familiarity with HTML, CSS, and JavaScript
●	Experience with relational databases and table data structures
●	Experience with Git and GitHub
●	Command Line Interface knowledge


Technical Requirements
This course builds out all the required software needed to complete the course.
However, as of 10/28/2018 ASP.NET Core 3.0 isn’t ready for public consumption. I gloss over the install in video 1.2. NuGet packages for ASP.NET 3.0 aren’t on the public server. So you have to compile them yourself and add the local copies of these files to a NuGet.config file. To really develop this, you will need to perform the following steps:
1)	Install .NET Core SDK
2)	Install VS Code
3)	Install VS 2017 (Community Edition should work, I tested on Enterprise)
a.	Install the following Workloads:
i.	.NET Desktop Development
ii.	Desktop Development with C++
1.	Include the following options
a.	Windows 8.1 SDK
b.	Windows 10 SDK (10.0.15063.0) for Desktop C++
c.	VC++ 2015.3 v14.00 (v140) toolset for desktop
iii.	Visual Studio extension development
iv.	.NET Core cross-platform development
4)	Install Git
5)	Install Node.js (I use version 11, but one of the 8’s should work fine too)
6)	git clone --recursive https://github.com/aspnet/AspNetCore
7)	Build from this source with a build number of 10062 (this will take ~20 minutes)
a.	C:\src\aspnet\AspNetCore\build.cmd /p:Configuration=Release /p:BuildNumber=10062 /p:SkipTests=true
8)	Update the NuGet.config in the %appdir%/NuGet/ folder to be as follows:
<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <packageSources>
        <clear />
        <add key="MyBuildOfAspNetCore" value="C:\src\aspnet\AspNetCore\artifacts\build\" />
        <add key="NuGet.org" value="https://api.nuget.org/v3/index.json" />
    </packageSources>
</configuration>


Related Products
