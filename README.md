## $5 Tech Unlocked 2021!
[Buy and download this product for only $5 on PacktPub.com](https://www.packtpub.com/)
-----
*The $5 campaign         runs from __December 15th 2020__ to __January 13th 2021.__*

# Beginning ASP.NET Core 3.0 [Video]
This is the code repository for [Beginning ASP.NET Core 3.0 [Video]](https://www.packtpub.com/web-development/beginning-aspnet-core-30-video?utm_source=github&utm_medium=repository&utm_campaign=9781789619355), published by [Packt](https://www.packtpub.com/?utm_source=github). It contains all the supporting project files necessary to work through the video course from start to finish.
## About the Video Course
ASP.NET Core 3.0 is one of the fastest server-side web frameworks available. It provides developers with a robust, flexible and efficient tool to build amazing web apps and services. 
	This course will be thoroughly practical, focusing on getting started with ASP.NET Core 3.0 and the .NET Core 3.0 framework, and putting them into practice to build an amazing web application. This course will teach you the essentials for getting started in ASP.NET Core 3.0. You will learn to take advantage of the various features of the framework and work with the well-known code editor, Visual Studio Code.
By the end of the course, you will build your skills to meet the demands of modern-day application development and simplify modern back end web development with ASP.NET Core 3.0.


<H2>What You Will Learn</H2>
<DIV class=book-info-will-learn-text>
<UL>
<LI>Build secure, flexible, scalable &amp; super-fast simple web applications and develop back-end with ASP.NET Core 3.0 to cater to business and customer needs. 
<LI>Develop the core skills needed to get started and build ASP.NET Core 3.0 applications. 
<LI>Design a database using the latest Entity Framework Core. 
<LI>Use Razor Pages to make coding page-focused scenarios easier and dynamic. 
<LI>Explore Visual Studio Code so that you can be as productive as possible. </LI></UL></DIV>

## Instructions and Navigation
### Assumed Knowledge
To fully benefit from the coverage included in this course, you will need:<br/>
●	Prior working knowledge of C#<br/>
●	Familiarity with HTML, CSS, and JavaScript<br/>
●	Experience with relational databases and table data structures<br/>
●	Experience with Git and GitHub<br/>
●	Command Line Interface knowledge<br/>

### Technical Requirements<br/>
This course has the following software requirements:<br/>
This course builds out all the required software needed to complete the course.<br/>
However, as of 10/28/2018 ASP.NET Core 3.0 isn’t ready for public consumption. I gloss over the install in video 1.2. NuGet packages for ASP.NET 3.0 aren’t on the public server. So you have to compile them yourself and add the local copies of these files to a NuGet.config file. To really develop this, you will need to perform the following steps:<br/>
1)	Install .NET Core SDK<br/>
2)	Install VS Code<br/>
3)	Install VS 2017 (Community Edition should work, I tested on Enterprise)<br/>
a.	Install the following Workloads:<br/>
i.	.NET Desktop Development<br/>
ii.	Desktop Development with C++<br/>
1.	Include the following options<br/>
a.	Windows 8.1 SDK<br/>
b.	Windows 10 SDK (10.0.15063.0) for Desktop C++<br/>
c.	VC++ 2015.3 v14.00 (v140) toolset for desktop<br/>
iii.	Visual Studio extension development<br/><br/>
iv.	.NET Core cross-platform development<br/>
4)	Install Git<br/>
5)	Install Node.js (I use version 11, but one of the 8’s should work fine too)<br/>
6)	git clone --recursive https://github.com/aspnet/AspNetCore<br/>
7)	Build from this source with a build number of 10062 (this will take ~20 minutes)<br/>
a.	C:\src\aspnet\AspNetCore\build.cmd /p:Configuration=Release /p:BuildNumber=10062 /p:SkipTests=true<br/>
8)	Update the NuGet.config in the %appdir%/NuGet/ folder to be as follows:<br/>
<?xml version="1.0" encoding="utf-8"?><br/>
<configuration><br/>
    <packageSources><br/>
        <clear /><br/>
        <add key="MyBuildOfAspNetCore" value="C:\src\aspnet\AspNetCore\artifacts\build\" /><br/>
        <add key="NuGet.org" value="https://api.nuget.org/v3/index.json" /><br/>
    </packageSources><br/>
</configuration><br/>
Once these steps have been completed you should be able to follow along with the videos. This is only temporary until more final builds of ASP.NET Core 3.0 and the .NET Core 3.0 SDK come along.<br/>
Note: As of December 4th, ASP.NET Core 3.0 Preview 1 has been released. The videos are updated for that release. The above pre-requisite is no longer needed, and you can return the NuGet back to the way it was previously. All you need to do is to install the preview from https://dotnet.microsoft.com/download/dotnet-core/3.0<br/>


## Related Products
* [Full Stack Development with React and ASP.NET Core 2 [Video]](https://www.packtpub.com/web-development/full-stack-development-react-and-aspnet-core-2-video?utm_source=github&utm_medium=repository&utm_campaign=9781789618754)

* [ASP.NET Core Full-Stack Development Projects [Video]](https://www.packtpub.com/web-development/aspnet-core-full-stack-development-projects-video?utm_source=github&utm_medium=repository&utm_campaign=9781788998215)

* [Getting Started with ASP.NET Core MVC [Video]](https://www.packtpub.com/application-development/getting-started-aspnet-core-mvc-video?utm_source=github&utm_medium=repository&utm_campaign=9781786461957)

