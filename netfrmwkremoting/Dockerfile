#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see http://aka.ms/containercompat 

#FROM mcr.microsoft.com/dotnet/framework/runtime:4.7.2-windowsservercore-ltsc2019
FROM mcr.microsoft.com/dotnet/framework/runtime:4.8

WORKDIR /app
EXPOSE 8789
COPY ./bin/release/netfrmwkremoting.exe .
ENTRYPOINT ["C:\\app\\netfrmwkremoting.exe"]
