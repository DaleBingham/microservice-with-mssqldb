# use MSSQL 2017 image on Ubuntu 16.04
FROM microsoft/mssql-server-linux:latest

# create directory within SQL container for database files
RUN mkdir -p /opt/dbscripts

# copy the database files from host to container
COPY *.sql /opt/dbscripts/

# set environment variables
ENV MSSQL_SA_PASSWORD=mysapwdn0tGo0d!
ENV ACCEPT_EULA=Y
ENV MSSQL_PID=Express

RUN /opt/mssql/bin/sqlservr --accept-eula & sleep 10 \
    && /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P 'mysapwdn0tGo0d!' -i /opt/dbscripts/dbcreate.sql \
    && pkill sqlservr 