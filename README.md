# cloudscribe.Core.Data
Various database implementations for the cloudscribe.Core.Models repository interfaces

## Background

The cloudscribe Core projects started out using a lot of existing data access code from the mojoPortal project. mojoPortal is a web content system built on the older ASP.NET WebForms framework and is no longer being actively developed except for security fixes. Since I had a lot of good data access code for mutliple data platforms to start with and since I wanted to facilitate a possibility for easy migration of mojoPortal sites and users to cloudscribe I started the cloudscribe project by refactoring the mojoportal data access code.

A goal of the cloudscribe Core project is to not impose a specific ORM (Object Relational Mapper) and these data access layers provide options for those who would rather work with straight forward, old fashioned, ADO.NET. The ADO.NET data layers in this repo were actually the first implementations of data access for [cloudscribe Core](https://github.com/joeaudette/cloudscribe). Since Entity Framework Core, the new ORM from Microsoft, will be the recommended method of data access from Microsoft going forward, I also expect that a lot of people will want to use Entity Framework Core, and I wanted to learn how to use it myself so I implemented a newer data layer for cloudscribe Core using Entity Framework Core. Once I got up to speed on EF, I realized how valuable the rapid development benefits of using it can be, how easy it is to make changes in the model, and how much less code I have to write. So I decided that I would use Entity Framework Core as the primary data access layer to allow much faster progress than trying to keep all these data access layers in lock step with each model change. So I moved the ADO data layers here into this separate code repository so they can be updated at a different cadence than the main cloudscribe Core project. This means I can work much faster on cloudscribe Core to get the model evolved to where I want it, then come back later and update these data access layers as time permits and according to feedback and demand.

## What About NoSql?

I'm kind of interested in MongoDB myself, and plan to try implementing a set of cloudscribe Core data repositories using MongoDB. I'd like some help with that but I think I can do the preliminary work to get the ball rolling and then maybe someone will volunteer to help implement more of the repositopry methods to complete it. From my initial study, C# code for Mongo looks fairly similar to Entity Framework code, so it could be informed by that code.

## Help Wanted

There are 2 ways that you could be of help. The first is to provide feedback, if you are using one of these data access layers and you see it has fallen behind in implementation, let us know you are using it, the more feedback we get that something is being used the more priority it will get. I monitor the cloudscribe gitter chat on a regular basis and you can leave a massage there to let me know which data layers are important to you. You can also ask general questions or just be social.

[![Join the chat at https://gitter.im/joeaudette/cloudscribe](https://badges.gitter.im/joeaudette/cloudscribe.svg)](https://gitter.im/joeaudette/cloudscribe?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

You could offer to help maintain the code for one or more of these data layers that is important to you. I can tell you that my order of priority for these data layers is:

*  MSSQL - this ADO.NET data layer supports MS SQL Server and SqlAzure and uses 100% stored procedures which can be tuned for best possible performance, and using stored procedures has a security hardening advantage over other data layers, because after intallation you can use a least priveledge sql user in the connection string with only EXEC permission on the stored procedures and no other direct permissions on any database object. You can't do that with any ORM becuase they generate dynamic queries.
*  pgsql - depending on how successful I am in using Entity Framework Core with PostgreSql, this data layer would be important especially for use on Linux or OSX. I know the [npgsql](https://github.com/npgsql/npgsql) team is working on Entity Framework Core support, and likely I will try using that, but if I run into bugs or other gotchas, I feel confient that the old fashioned ADO.NET code should work
*  Sqlite - one cool thing that will be possible in the future using Sqlite is to make a read only web app that can run from a CDROM/DVDROM. Could be useful for kiosks or possibly data could be migrated from another db into Sqlite to provide a snapshot backup of a site at a given point in time. This is possible because Sqlite is a single file database that requires no additional database server software. However, Sqlite is also supported for Entity Framework Core so there may not be much value in maintaining this ADO.NET data layer.
*  MySql - a very popular data platform, I used it for mojoportal.com, but I'm less interested in it these days. I think PostgresSql is a better choice. I might maintain this if there is a lot of demand but I would certainly welcome help from someone else who is more invested in using it. Currently the MySql ADO drivers only support the full desktop framework but I expect that Oracle will release updated drivers for .NET Core at some point.
*  Firebird - This one is very likey to be neglected going forward unless someone else steps up to champion it. It wasn't very popular for mojoPortal and I'm not really expecting it to be very popular for cloudscribe. Current ADO.NET drivers for Firebird only support the full desktop framework.
*  SqlCe SqlServer Compact edition is a single file database from Microsoft that is in many ways similar to Sqlite. Currently the SqlCE ADO.NET drivers only support the full desktop framework, but I expect there will be updated .NET Core drivers and support for using it with Entity Framework Core, so there may not be much value in maintaining this ADO.NET data layer.

This project is part of the cloudscribe set of projects which are all being managed under the same policies.
See the CONTRIBUTING.md file in the main cloudscribe repository if you are interested in helping maintain this code:
https://github.com/joeaudette/cloudscribe/blob/master/CONTRIBUTING.md

## Related Projects

*  [cloudscribe.Setup](https://github.com/joeaudette/cloudscribe.Setup) the ADO.NET data layers don't have a code dependency on cloudscribe.Setup but are by convention designed to be used with cloudscribe.Setup which handles execution of the install and upgrade sql scripts
