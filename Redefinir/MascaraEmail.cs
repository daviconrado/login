using System;

class MascaraEmail
{
    public static string MaskEmail(string email)
    {
        string[] emailParts = email.Split('@');

        string username = emailParts[0];
        string domain = emailParts[1];

        string maskedUsername = username.Substring(0,2) + new string('*', username.Length);
        string maskedDomain = domain.Substring(0,2) + new string('*', domain.Length);

        return maskedUsername + "@" + maskedDomain;
    }
}