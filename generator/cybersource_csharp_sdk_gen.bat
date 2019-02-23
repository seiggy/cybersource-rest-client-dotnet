java -jar swagger-codegen-cli-2.2.3.jar generate -t cybersource-csharp-template -i cybersource-rest-spec.json -l csharp -o ../ -c cybersource-csharp-config.json

rem For removing trailing forward slash from endpoints
powershell -Command "(Get-Content ..\src\CyberSource\Api\CreditApi.cs) | ForEach-Object { $_ -replace '/pts/v2/credits/', '/pts/v2/credits' } | Set-Content ..\src\CyberSource\Api\CreditApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\PaymentsApi.cs) | ForEach-Object { $_ -replace '/pts/v2/payments/', '/pts/v2/payments' } | Set-Content ..\src\CyberSource\Api\PaymentsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\ProcessAPayoutApi.cs) | ForEach-Object { $_ -replace '/pts/v2/payouts/', '/pts/v2/payouts' } | Set-Content ..\src\CyberSource\Api\ProcessAPayoutApi.cs"


rem For Converting the datetime values to string while passing them to the query params object
powershell -Command "(Get-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs) | ForEach-Object { $_ -replace 'ParameterToString\(reportDate\)', 'ParameterToString(reportDate.Value.ToString("""yyyy-MM-dd"""))' } | Set-Content ..\src\CyberSource\Api\ReportDownloadsApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\SecureFileShareApi.cs) | ForEach-Object { $_ -replace 'ParameterToString\(startDate\)', 'ParameterToString(startDate.Value.ToString("""yyyy-MM-dd"""))' } | Set-Content ..\src\CyberSource\Api\SecureFileShareApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\SecureFileShareApi.cs) | ForEach-Object { $_ -replace 'ParameterToString\(endDate\)', 'ParameterToString(endDate.Value.ToString("""yyyy-MM-dd"""))' } | Set-Content ..\src\CyberSource\Api\SecureFileShareApi.cs"


rem For Converting the datetime values to string while appending them to the localVarPath and commenting out the values being set in query params obj
powershell -Command "(Get-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs) | ForEach-Object { $_ -replace '/pts/v1/transaction-batches', '/pts/v1/transaction-batches?startTime={startTime.Value.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")}&endTime={endTime.Value.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")}' } | Set-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs) | ForEach-Object { $_ -replace 'if \(startTime != null\)', '//if (startTime != null)' } | Set-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs) | ForEach-Object { $_ -replace 'if \(endTime != null\)', '//if (endTime != null)' } | Set-Content ..\src\CyberSource\Api\TransactionBatchesApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[660] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[661] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[662] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[663] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[664] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[665] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[666] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[667] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[668] = ''; $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Api\ReportsApi.cs) ; $fileContents[638] = (get-content ReportsApiLocalVarPath.txt); $fileContents|Set-Content ..\src\CyberSource\Api\ReportsApi.cs"


rem For Removing the length check for a property which is currently giving compile time error
powershell -Command "$fileContents = (get-content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs) ; $fileContents[448] = ''; $fileContents|Set-Content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs) ; $fileContents[449] = ''; $fileContents|Set-Content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs) ; $fileContents[450] = ''; $fileContents|Set-Content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs) ; $fileContents[451] = ''; $fileContents|Set-Content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs"

powershell -Command "$fileContents = (get-content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs) ; $fileContents[452] = ''; $fileContents|Set-Content ..\src\CyberSource\Model\PtsV2PaymentsPost201ResponsePaymentInformationAccountFeatures.cs"


rem For Adding missing properties in the model file
powershell -Command "(Get-Content ..\src\CyberSource\Model\Ptsv2paymentsidcapturesPointOfSaleInformation.cs) | ForEach-Object { $_ -replace 'AmexCapnData = default\(string\)', 'AmexCapnData = default(string), bool CardPresent = default(bool), string CatLevel = default(string), string TerminalCapability = default(string)' } | Set-Content ..\src\CyberSource\Model\Ptsv2paymentsidcapturesPointOfSaleInformation.cs"

powershell -Command "(Get-Content ..\src\CyberSource\Model\Ptsv2paymentsidcapturesPointOfSaleInformation.cs) | ForEach-Object { $_ -replace \"this.AmexCapnData = AmexCapnData;\", \"this.AmexCapnData = AmexCapnData;`r`n`t`t`tthis.CardPresent = CardPresent;`r`n`t`t`tthis.CatLevel = CatLevel;`r`n`t`t`tthis.TerminalCapability = TerminalCapability;\" } | Set-Content ..\src\CyberSource\Model\Ptsv2paymentsidcapturesPointOfSaleInformation.cs"


powershell -Command "(Get-Content ..\src\CyberSource\Model\Ptsv2paymentsidcapturesPointOfSaleInformation.cs) | ForEach-Object { $_ -replace 'public string AmexCapnData { get; set; }', 'public string AmexCapnData { get; set; }[DataMember(Name = \"CardPresent\", EmitDefaultValue = false)]public bool CardPresent { get; set; }[DataMember(Name = \"CatLevel\", EmitDefaultValue = false)]public string CatLevel { get; set; }[DataMember(Name = \"TerminalCapability\", EmitDefaultValue = false)]public string TerminalCapability { get; set; }' } | Set-Content ..\src\CyberSource\Model\Ptsv2paymentsidcapturesPointOfSaleInformation.cs"


rem For renaming the Assembly name in csproj file
powershell -Command "(Get-Content ..\src\CyberSource\CyberSource.csproj) | ForEach-Object { $_ -replace '<AssemblyName>Cybersource', '<AssemblyName>cybersource-rest-client-dotnet' } | Set-Content ..\src\CyberSource\CyberSource.csproj"

rem For Renaming the .csproj file Name from Cybersource to cybersource-rest-client-dotnet
powershell Rename-Item ..\src\CyberSource\CyberSource.csproj cybersource-rest-client-dotnet.csproj

rem For Renaming the Project Folder Name from Cybersource to cybersource-rest-client-dotnet
powershell Rename-Item ..\src\CyberSource cybersource-rest-client-dotnet

pause