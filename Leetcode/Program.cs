// See https://aka.ms/new-console-template for more information
using Leetcode.Solutions;
using System.Data;
using System.Dynamic;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
public class Program
{
    public static void Main(string[] args)
    {
        int[][] trust = { new int[] { 1,2} };
        int n = 2;
        FindTheTownJudge sol = new FindTheTownJudge();
        int result = sol.FindJudge(n, trust);
        Console.WriteLine(result);
    }
}

public class Solution
{

    public int getDiscountedPrice(int barcode)
    {

        string url = "https://jsonmock.hackerrank.com/api/inventory?barcode=" + barcode;
        WebRequest request = WebRequest.Create(url);
        string jsonResponse;
        // Get the response from the API
        using (WebResponse response = request.GetResponse())
        {
            // Get the response stream
            using (Stream dataStream = response.GetResponseStream())
            {
                // Read the response stream
                using (StreamReader reader = new StreamReader(dataStream))
                {
                    // Read the content of the response
                    jsonResponse = reader.ReadToEnd();

                    // Print the JSON response
                    Console.WriteLine(jsonResponse);
                }
            }
        }
        dynamic data = JsonConvert.DeserializeObject(jsonResponse);
        int result = 0;
        if (data?.data.Count == 0)
        {
            return -1;
        }
        else
        {
            float discount = data.data[0].discount;
            float price = data.data[0].price;
            Console.WriteLine(price);
            Console.WriteLine(discount);
            float discountedPrice = price - ((discount / 100) * price);
            Console.WriteLine(discountedPrice);
            result = (int)Math.Round(discountedPrice);
            Console.WriteLine(result);
        }

        return result;
    }
}
