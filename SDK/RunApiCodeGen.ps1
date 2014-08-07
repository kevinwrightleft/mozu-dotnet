
param(
[int]$Major=$(throw "Major param is required"),
[int]$Minor=$(throw "Minor param is required"),
[ValidateSet("ci","si","qa")]
[string]$Env=$(throw "Env param is required"),
[string]$GenPath=$(throw "GenPath param is required"),
[string]$CodeGenBaseUrl=$(throw "CodeGenBaseUrl param is required"),
[string]$AppClaim=$(throw "CodeGenBaseUrl param is required"),
[boolean]$RunPublisher
)


if ($RunPublisher)
{
    $server = "";
    switch($env) 
    {
        "ci"{$server="http://aus02ncserv001.dev.volusion.com"}
        "si"{$server="http://AUS02NISERV001.dev.volusion.com"}
        "qa"{$server="http://services-mozu-qa.dev.volusion.com"}
    }

    $uri = "$server/Mozu.ApiAdmin.WebApi/publish/build/apimajorminor";

    $headers = @{
        "x-vol-app-claims" = "$AppClaim"
        "accept" = "application/json"
    };

    $body = "{
        ""major"" : ""$major"",
        ""minor"" : ""$minor""
    }";

    try {
        Invoke-RestMethod -Method Post -Uri $uri -Body $body -Headers $headers  -ContentType "application/json"
    }
    catch [System.Net.WebException] {
         Write-Host $_.Exception.ToString()
         throw;
    }
}

$CodeGenServer = "$CodeGenBaseUrl/Mozu.ApiCodeGen.WebApi"


try {
    $response = Invoke-WebRequest -Method Get -Uri "$CodeGenServer/sdkcodegen/$env/versions"  -ContentType "application/json" -UseBasicParsing

    Write-Host $response
    Write-Host $response.Headers
    Write-Host $response.StatusCode
    $versions = ConvertFrom-Json $response

    $versionToUse = $versions[0]

} catch [System.Net.WebException]
{
     Write-Host $_.Exception.ToString()
     throw;
}

$body = "{""environment"": ""$env"",""apiVersion"": ""$versionToUse"",""createChangeLog"": ""false"",""changeLogSourceApiVersion"": ""$versionToUse"",""languages"":  [""csharp""],""destinationDirectory"": ""$GenPath""}"

Write-Host $body

try 
{
    $response = Invoke-WebRequest -Method Post -Uri "$CodeGenServer/sdkcodegen" -Body $body -Headers $headers -ContentType "application/json" -ErrorAction Stop -UseBasicParsing
    Write-Host $response.StatusCode
    Write-Host $response.Headers
}
catch [System.Net.WebException] 
{
    Write-Host $_.Exception.ToString()
    throw;
}
