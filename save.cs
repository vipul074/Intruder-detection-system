using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net.Mail;



public class save
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cloud"].ConnectionString);

    public string SendEmail(string toAddress, string subject, string body)
    {
        string result = "Message Sent Successfully..!!";
        string senderID = "shikhars335@gmail.com";// use sender’s email id here..
        const string senderPassword = "shikharspanky1200"; // sender password here…
        try
        {
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com", // smtp server address here…
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new System.Net.NetworkCredential(senderID, senderPassword),
                Timeout = 30000,
            };
            MailMessage message = new MailMessage(senderID, toAddress, subject, body);
            smtp.Send(message);
        }
        catch (Exception ex)
        {
            result = "Error sending email.!!!";
        }
        return result;
    }
    public void insert(string query)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public string GetMacAddress()
    {
        string macAddresses = string.Empty;

        foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
        {
            if (nic.OperationalStatus == OperationalStatus.Up)
            {
                macAddresses += nic.GetPhysicalAddress().ToString();
                break;
            }
        }

        return macAddresses;
    }

}