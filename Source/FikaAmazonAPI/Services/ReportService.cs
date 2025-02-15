﻿using AmazonSpApiSDK.Models;
using AmazonSpApiSDK.Models.Orders;
using AmazonSpApiSDK.Models.Reports;
using FikaAmazonAPI.Parameter.Report;
using FikaAmazonAPI.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FikaAmazonAPI.Services
{
    public class ReportService : RequestService
    {
        public ReportService(AmazonCredential amazonCredential) : base(amazonCredential)
        {
        }
        #region GetReport
        public List<Report> GetReports(ParameterReportList parameterReportList)
        {
            var parameters = parameterReportList.getParameters();

            CreateAuthorizedRequest(ReportApiUrls.GetReports, RestSharp.Method.GET, parameters);
            var response = ExecuteRequest<GetReportsResponseV00>();
            parameterReportList.nextToken = response.NextToken;
            var list = response.Reports;
            list.AddRange(list);

            while (!string.IsNullOrEmpty(parameterReportList.nextToken))
            {
                var nextTokenResponse = GetReportsByNextToken(parameterReportList);
                list.AddRange(nextTokenResponse.Reports);
                parameterReportList.nextToken = nextTokenResponse.NextToken;
            }
            return list;
        }

        public Report GetReport(string reportId)
        {

            CreateAuthorizedRequest(ReportApiUrls.GetReport(reportId), RestSharp.Method.GET);
            var response = ExecuteRequest<Report>();
            if (response != null)
                return response;
            return null;
        }
        public bool CancelReport(string reportId)
        {

            CreateAuthorizedRequest(ReportApiUrls.CancelReport(reportId), RestSharp.Method.DELETE);
            var response = ExecuteRequest<CancelReportResponse>();
            if (response != null && response.Errors != null)
                return false;
            return true;
        }

        public ReportScheduleList GetReportSchedules(ParameterReportSchedules parametersSchedules)
        {
            var parameters = parametersSchedules.getParameters();
            CreateAuthorizedRequest(ReportApiUrls.GetReportSchedules, RestSharp.Method.GET, parameters);
            var response = ExecuteRequest<GetReportSchedulesResponseV00>();
            if (response != null && response.ReportSchedules != null)
                return response.ReportSchedules;
            return null;
        }

        private GetReportsResponseV00 GetReportsByNextToken(ParameterReportList parameterReportList)
        {
            var parameterReportListNew = new ParameterReportList();
            parameterReportListNew.nextToken = parameterReportList.nextToken;
            var parameters = parameterReportListNew.getParameters();

            CreateAuthorizedRequest(ReportApiUrls.GetReports, RestSharp.Method.GET, parameters);
            var response = ExecuteRequest<GetReportsResponseV00>();
            return response;
        }

        public string CreateReport(ParameterCreateReportSpecification createReportSpecification)
        {
            CreateAuthorizedRequest(ReportApiUrls.CreateReport, RestSharp.Method.POST, null, createReportSpecification);
            var response = ExecuteRequest<AmazonSpApiSDK.Models.Reports.CreateReportResult>();

            if (response == null)
                return null;


            return response.ReportId;
        }

        public string CreateReportSchedule(ParameterCreateReportScheduleSpecification createReportScheduleSpecification)
        {
            CreateAuthorizedRequest(ReportApiUrls.CreateReportSchedule, RestSharp.Method.POST, null, createReportScheduleSpecification);
            var response = ExecuteRequest<CreateReportScheduleResult>();

            if (response == null)
                return null;


            return response.ReportScheduleId;
        }

        public ReportSchedule GetReportSchedule(string reportScheduleId)
        {

            CreateAuthorizedRequest(ReportApiUrls.GetReportSchedule(reportScheduleId), RestSharp.Method.GET);
            var response = ExecuteRequest<ReportSchedule>();
            if (response != null)
                return response;
            return null;
        }

        public ReportDocument GetReportDocument(string reportDocumentId)
        {
            CreateAuthorizedRequest(ReportApiUrls.GetReportDocument(reportDocumentId), RestSharp.Method.GET);
            var response = ExecuteRequest<ReportDocument>();
            if (response != null)
                return response;
            return null;
        }
        public string GetReportFile(string reportDocumentId)
        {
            var reportDocument = GetReportDocument(reportDocumentId);
            return GetFile(reportDocument);
        }

        private string GetFile(ReportDocument reportDocument)
        {
            bool IsCompressionFile = false;
            bool IsEncryptedFile = false;

            if (reportDocument.EncryptionDetails != null)
                IsEncryptedFile = true;
            if (reportDocument.CompressionAlgorithm != null && reportDocument.CompressionAlgorithm.HasValue && reportDocument.CompressionAlgorithm.Value == ReportDocument.CompressionAlgorithmEnum.GZIP)
                IsCompressionFile = true;


            var client = new System.Net.WebClient();
            string fileName = Guid.NewGuid().ToString();
            

            if (IsCompressionFile)
            {
                client.Headers[System.Net.HttpRequestHeader.AcceptEncoding] = "gzip";
                fileName += ".gz";
            }else fileName += ".txt";

            string tempFilePath = Path.Combine(Path.GetTempPath() + fileName);



            if (IsEncryptedFile)
            {
                //Later will check
                //byte[] rawData = client.DownloadData(reportDocument.Url);
                //byte[] key = Convert.FromBase64String(reportDocument.EncryptionDetails.Key);
                //byte[] iv = Convert.FromBase64String(reportDocument.EncryptionDetails.InitializationVector);
                //var reportData = FileTransform.DecryptString(key, iv, rawData);
                //File.WriteAllText(tempFilePath, reportData);
                return tempFilePath;
            }
            else
            {
                
                var stream = client.OpenRead(reportDocument.Url);
                //var responseStream = new System.IO.Compression.GZipStream(rawData, System.IO.Compression.CompressionMode.Decompress);
                using (Stream s = File.Create(tempFilePath))
                {
                    stream.CopyTo(s);
                }

               return FileTransform.Decompress(tempFilePath);
                //SaveStreamToFile(tempFilePath, responseStream);

            }

            
        }




        public void SaveStreamToFile(string fileFullPath, Stream stream)
        {
            if (stream.Length == 0) return;

            // Create a FileStream object to write a stream to a file
            using (FileStream fileStream = System.IO.File.Create(fileFullPath, (int)stream.Length))
            {
                // Fill the bytes[] array with the stream data
                byte[] bytesInStream = new byte[stream.Length];
                stream.Read(bytesInStream, 0, (int)bytesInStream.Length);

                // Use FileStream object to write to the specified file
                fileStream.Write(bytesInStream, 0, bytesInStream.Length);
            }
        }
        public bool CancelReportSchedule(string reportScheduleId)
        {

            CreateAuthorizedRequest(ReportApiUrls.CancelReportSchedule(reportScheduleId), RestSharp.Method.DELETE);
            var response = ExecuteRequest<CancelReportScheduleResponse>();
            if (response != null && response.Errors != null)
                return false;
            return true;
        }
        #endregion
    }
}
