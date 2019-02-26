﻿using System.IO;
using AuthenticationSdk.core;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;
using CybsQaScript.Csv_HelperClasses;
using LumenWorks.Framework.IO.Csv;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Collections.Generic;
using System;

namespace CybsQaScript.Payments.Authorize_Payment.CVN
{
    public class CvnVisaCvv2
    {
        public static void CreatePaymentExec()
        {
            // Initialize Api Name
            var apiFunctionName = "CvnVisaCvv2";

            // To Load the previous Data in the output file---
            var dataAppend = new DataAppend();
            var recordsPrev = dataAppend.ReadPrevData();

            // Reading the CSV input file
            using (var csv =
                new CsvReader(new StreamReader(@"../../CSV_Files/Payment/AuthorizePayment/CVN/CreateVisaCVV2.csv"), true))
            {
                var fieldCount = csv.FieldCount;

                // Writing  to output CSV file
                using (var writer = new CsvFileWriter(@"../../CSV_Files/TestReport/TestResults.csv"))
                {
                    var flag = 0;
                    var headers = csv.GetFieldHeaders();

                    while (csv.ReadNextRecord())
                    {
                        // Read Input Csv File
                        string amount = null;
                        string testCaseId = null;
                        string message = null;

                        for (int i = 0; i < fieldCount; i++)
                        {
                            switch (headers[i])
                            {
                                case "testCaseId":
                                    testCaseId = csv[i];
                                    break;
                                case "amount":
                                    amount = csv[i];
                                    break;
                                case "message":
                                    message = csv[i];
                                    break;
                            }
                        }

                        // Write to output file
                        var row = new CsvRow();

                        // Intialize Api Configuration and client configuration
                        var configDictionary = new Configuration().GetConfiguration();
                        var clientConfig = new CyberSource.Client.Configuration(merchConfigDictObj: configDictionary);

                        try
                        {
                            // To write existing data of output csv file
                            if (flag == 0)
                            {
                                row.Add("TestCaseId");
                                row.Add("APIName");
                                row.Add("Status");
                                row.Add("TimeStamp");
                                writer.WriteRow(row);

                                // Write previous records
                                foreach (var item in recordsPrev)
                                {
                                    var rowPrev = new CsvRow
                                    {
                                        item.TestCaseId,
                                        item.APIName,
                                        item.Status,
                                        item.TimeStamp
                                    };
                                    writer.WriteRow(rowPrev);
                                }

                                flag = flag + 1;
                            }

                            var requestObj = new CreatePaymentRequest();

                            var v2PaymentsClientReferenceInformationObj = new Ptsv2paymentsClientReferenceInformation
                            {
                                Code = "TC1102345"
                            };

                            requestObj.ClientReferenceInformation = v2PaymentsClientReferenceInformationObj;

                            var deviceInformationObj = new Ptsv2paymentsDeviceInformation
                            {
                                HostName = "cybersource.com",
                                IpAddress = "66.185.179.2"
                            };

                            requestObj.DeviceInformation = deviceInformationObj;

                            var v2PaymentsProcessingInformationObj = new Ptsv2paymentsProcessingInformation();

                            var authorizationOptionsObj = new Ptsv2paymentsProcessingInformationAuthorizationOptions
                            {
                                IgnoreAvsResult = true,
                                IgnoreCvResult = false
                            };

                            v2PaymentsProcessingInformationObj.AuthorizationOptions = authorizationOptionsObj;

                            requestObj.ProcessingInformation = v2PaymentsProcessingInformationObj;

                            var buyerInformationObj = new Ptsv2paymentsBuyerInformation();
                            var list = new List<Ptsv2paymentsBuyerInformationPersonalIdentification>();
                            var personalIdentificationObj = new Ptsv2paymentsBuyerInformationPersonalIdentification
                            {
                                Id = "123* 4sÃ†"
                            };

                            list.Add(personalIdentificationObj);

                            buyerInformationObj.PersonalIdentification = list;

                            requestObj.BuyerInformation = buyerInformationObj;

                            var v2PaymentsOrderInformationObj = new Ptsv2paymentsOrderInformation();

                            var v2PaymentsOrderInformationBillToObj = new Ptsv2paymentsOrderInformationBillTo
                            {
                                Country = "US",
                                LastName = "Deo",
                                Address2 = "test",
                                Address1 = "201 S. Division St.",
                                PostalCode = "48104-2201",
                                Locality = "Ann Arbor",
                                AdministrativeArea = "MI",
                                FirstName = "John",
                                PhoneNumber = "999999999",
                                District = "MI",
                                BuildingNumber = "123",
                                Company = "Visa",
                                Email = "test@cybs.com"
                            };

                            v2PaymentsOrderInformationObj.BillTo = v2PaymentsOrderInformationBillToObj;

                            var amountDetailsObj = new Ptsv2paymentsOrderInformationAmountDetails
                            {
                                TotalAmount = amount,
                                Currency = "usd"
                            };

                            v2PaymentsOrderInformationObj.AmountDetails = amountDetailsObj;

                            requestObj.OrderInformation = v2PaymentsOrderInformationObj;

                            var v2PaymentsPaymentInformationObj = new Ptsv2paymentsPaymentInformation();

                            var v2PaymentsPaymentInformationCardObj = new Ptsv2paymentsPaymentInformationCard
                            {
                                ExpirationYear = "2031",
                                Number = "372425119311008",
                                SecurityCode = "1111",
                                ExpirationMonth = "12",
                                Type = "003",
                                SecurityCodeIndicator = "1"
                            };

                            v2PaymentsPaymentInformationObj.Card = v2PaymentsPaymentInformationCardObj;

                            requestObj.PaymentInformation = v2PaymentsPaymentInformationObj;

                            var apiInstance = new PaymentsApi(clientConfig);

                            var response = apiInstance.CreatePayment(requestObj);
                            Console.WriteLine(response);

                            if (response != null)
                            {
                                var row1 = new CsvRow
                                {
                                  testCaseId,
                                  apiFunctionName,
                                  $"Pass:{clientConfig.ApiClient.ApiResponse.StatusCode}- {response.Id}",
                                   DateTime.Now.ToString("yyyy/MM/dd" + "::" + "HH:mm:ss:fff")
                                };

                                writer.WriteRow(row1);

                                Console.WriteLine(testCaseId + "Success " + message);

                                flag = flag + 1;
                            }

                        }
                        catch (Exception e)
                        {
                            var row2 = new CsvRow
                            {
                                testCaseId,
                                apiFunctionName,
                                $"Fail:{clientConfig.ApiClient.ApiResponse.StatusCode} - {e.Message}",
                                DateTime.Now.ToString("yyyy/MM/dd" + "::" + "HH:mm:ss:fff")
                            };
                            writer.WriteRow(row2);
                            flag = flag + 1;
                            Console.WriteLine(testCaseId + "Error Message: " + e.Message);
                        }
                    }
                }
            }
        }
    }
}