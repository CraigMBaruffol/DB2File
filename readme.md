# DB2File

Db2File is a service that will facilitate extracting of data from a database using a SQL statement in the configuration, and export the data on a schedule to a file specified by the configuration.

## Source Databases

These are the databases that the system will run the provided query to extract data:

- SQL Server
- Oracle
- DB2
- PostgreSQL

## Target Files

These are the files to which the system will extract the data too:

- CSV - Single query
- Json - Single query (Consider multiple queries with inner lists)
- XML - Single query.
- Excel - Multiple queries - 1 per TAB (No template)
- Excel Template - Using keywords to identify the columns the query fields link too.  Multiple queries - 1 per tab.

# Technology Overview

This project will make use of the following technologies (List may grow over the development of the service):

- Visual Studio 2022 Project (C#) using
  - Blazor for configuration and reporting web interface (WEB ASSEMBLY).
  - Entity Framework for internal database interfaces.
  - Dapper for Source database query extracts.
  - Rest API for UI functional interface.
  - Worker Services for threaded processing.

# Overview
