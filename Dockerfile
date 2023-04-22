#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SkillCheck/SkillCheck.csproj", "SkillCheck/"]
COPY ["SkillCheck-BE-DataRepository-Audits/SkillCheck_BE_DataRepository_Audits.csproj", "SkillCheck-BE-DataRepository-Audits/"]
COPY ["SkillCheck_BE-Entities-Audits/SkillCheck_BE-Entities-Audits.csproj", "SkillCheck_BE-Entities-Audits/"]
RUN dotnet restore "SkillCheck/SkillCheck.csproj"
COPY . .
WORKDIR "/src/SkillCheck"
RUN dotnet build "SkillCheck.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SkillCheck.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SkillCheck.dll"]