﻿using Aspose.Words;
using Aspose.Words.MailMerging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharp.Mail_Merge
{
    class RemoveEmptyRegions
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_MailMergeAndReporting(); ;

            string fileName = "TestFile Empty.doc";
            // Open the document.
            Document doc = new Document(dataDir + fileName);

            // Create a dummy data source containing no data.
            DataSet data = new DataSet();

            // Set the appropriate mail merge clean up options to remove any unused regions from the document.
            doc.MailMerge.CleanupOptions = MailMergeCleanupOptions.RemoveUnusedRegions;

            // Execute mail merge which will have no effect as there is no data. However the regions found in the document will be removed
            // automatically as they are unused.
            doc.MailMerge.ExecuteWithRegions(data);

            dataDir = dataDir + RunExamples.GetOutputFilePath(fileName);
            // Save the output document to disk.
            doc.Save(dataDir);

            Debug.Assert(doc.MailMerge.GetFieldNames().Length == 0, "Error: There are still unused regions remaining in the document");

            Console.WriteLine("\nMail merge performed with empty regions successfully.\nFile saved at " + dataDir);
        }
    }
}
