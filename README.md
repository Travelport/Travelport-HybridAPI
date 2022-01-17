# Travelport-HybridAPI

## Objective
The objective of this repository is to provide developers with steps required to reference Travelport APIs (JSON and XML), and use the API to perform Search (Fare Family Shop) using JSON API, then execute an AirPrice request using the XML API. 

The project is using JSON API v11.1.

This repository contains folders as per the following hierarchy:

- root
    - HybridAPIFlow
        - HybridAPIFlow: Website MVC project 
        - HybridAPIFlow.BL: DLL project that hold the business logic
        - IO.Swagger: Reference to the JSON API
        - HybridAPIFlow.sln (the visual studio solution containing code for this project)

    - Screenshots: used in thie readme file
    - Swagger Files: the un-offical COP v11.1 modified as per below explaination
    - WSDL Files: to reference the XML API
    - Readme: this file :)

## Getting Started

To launch this solution, open the file HybridAPIFlow/HybridAPIFlow.sln in visual studio.

### Update the Web.Config to inlcude your API credentials

You will need to update the web.config keys with the JSON and XML API credentials for the application to work.

    <add key="jsonAPI_OAuthUsername" value="xxx" />
    <add key="jsonAPI_OAuthPassword" value="xxx" />
    <add key="jsonAPI_OAuthClientId" value="xxx" />
    <add key="jsonAPI_OAuthSecret" value="xxx" />
    <add key="jsonAPI_AccessGroup" value="xxx" />
    <add key="xmlBranchId" value="xxx" />
    <add key="xmlUsername" value="xxx" />
    <add key="xmlPassword" value="xxx" />

Make sure to change the endpoint to point to the correct enviroment (production or pre-production)

    <add key="xmlEndpoint" value="https://emea.universal-api.travelport.com/B2BGateway/connect/uAPI/AirService" />
    <add key="jsonAPI_OAuthEndPoint" value="https://oauth.travelport.com/oauth/oauth20/token" />
    <add key="jsonAPI_Endpoint" value="https://api.travelport.com" />

## Adding reference to JSON API
**The following steps are not required if you open the solution file in this repo. In case you want to start a new blank project and add reference to JSON and XML API, please follow these steps:**  

___Required:___
    Swagger file that will define the JSON API. The latest official swagger can be downloaded from this [link](https://support.travelport.com/webhelp/tripservices/Content/Downloads/Downloads.htm); This repo contains CPO_v11.1.json file that contains a non-offical CatalogProductOffering definition with some tweaks:

  - Added wrappers on request so that the request object is         
            
            
            CatalogProductOfferingsQueryRequestWrapper:
                properties:
                CatalogProductOfferingsQueryRequest:
                    $ref: '#/definitions/CatalogProductOfferingsQueryRequest'

    ![CatalogProductOfferingsQueryRequestWrapper diff](/Screenshots/Request-Object-Wrapper.png)

  - Added wrapper on the response so that the response object is 
           
            
            CatalogProductOfferingsResponseWrapper:
                properties:
                CatalogProductOfferingsResponse:
                    $ref: '#/definitions/CatalogProductOfferingsResponse'

    ![CatalogProductOfferingsResponseWrapper diff](/Screenshots/Response-Object-Wrapper.png)


The above changes are already made on the swagger file in the repo so no change is required. 
To generate the code from the swagger file, go to your favorite swagger codegen. We will use editor.swagger.io in this case: 

- Open the CPO_v11.1.json file in the page using File > Import File.
    ![Import swagger file](/Screenshots/editor-swagger-import-file.png)
- Generate a client code using Generate Client, then use csharp.
  ![Export swagger file](/Screenshots/editor-swagger-generate-client-csharp.png)
- This is automatically trigger a download of a zip file to your disk.
- Extract the zip file to your workspace, then open the project in Visual Studio. The generated code will have the project IO.Swagger that is included in this repo. 
- Make sure to install (re-install) nuget packages that are referenced in the generated code.


## Adding reference to XML API
Required:
    Wsdl files that will define the XML API. Included in this repo is AirServices WSDL files using for this project. 

- Step1: on a Visual Studio Project, right click on the References in the Solution Explorer. 
- Step2: Click on Add Service Reference
- Step3: Paste the location of the Wsdl file in the Address, then click on Go.
- Step4: For each of the wsdl files, give a Namespace, e.g., for AirService.wsdl i will give it the namespace AirServices

Repeat the above steps to add all the Wsdl references you need. You only need AirService for this project. 

In this repo, the reference to the XML API is added to the project HybridAPIFlow.BL project. This project also contains coding for calling JSON API and a helper class to execute both JSON and XML requests. 

The following xml configuration must be added to your web.config of your website under the configuration section so that AirPriceRequest are accepted by your webApp:

     <system.serviceModel>
        <bindings>
        <customBinding>
            <binding name="CustomServiceBinding" closeTimeout="00:01:00" openTimeout="00:01:00" receiveTimeout="00:10:00" sendTimeout="00:03:00">
            <textMessageEncoding messageVersion="Soap11" writeEncoding="utf-8">
                <readerQuotas maxDepth="32" maxStringContentLength="2147483646" maxArrayLength="2147483646" maxBytesPerRead="2147483646" maxNameTableCharCount="2147483646" />
            </textMessageEncoding>
            <httpsTransport maxBufferPoolSize="524288" maxReceivedMessageSize="2147483646" allowCookies="false" authenticationScheme="Basic" bypassProxyOnLocal="false" hostNameComparisonMode="StrongWildcard" keepAliveEnabled="false" maxBufferSize="2147483646" proxyAuthenticationScheme="Basic" transferMode="Buffered" useDefaultWebProxy="true" />
            </binding>
        </customBinding>
        </bindings>
    <client>
      <endpoint address="http://localhost:8080/kestrel/AirService" binding="customBinding" bindingConfiguration="CustomServiceBinding" contract="AirServices.AirPricePortType" name="AirPricePort" />
    </client>
    </system.serviceModel>

---------------------------------

## The following Packages using NuGet are required to run this code:

- ___RestSharp___
    The editor.swagger.io generated client project is using RestSharp v105.1.0; In case you update to the latest version, the generate code will not compile as a breaking change is introduced by RestSharp package. you will need to perform a manual change on the generated code:
    in ApiClient.cs line 137:  
             
        /*request.AddFile(param.Value.Name, param.Value.Writer, param.Value.FileName, param.Value.ContentType);*/
        request.AddFile(param.Value.Name, param.Value.Writer, param.Value.FileName, param.Value.ContentLength, param.Value.ContentType);
- ___Nlog___


NOTE: You might need to restore the packages for your project to compile. You can do this by right clicking on the solution in Visual Studio, then choose Restore NuGet packages.

  ![Restore NuGet packages](/Screenshots/Restore-Nuget-packages.png)
