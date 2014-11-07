using System;
using System.Security.Cryptography;
using System.Text;


public abstract class SHA256 : HashAlgorithm{
public static String encriptarContraseña(String contrasenia)
{
SHA256Managed encriptar = new SHA256Managed();
string hash = String.Empty;
byte[] encriptacion = encriptar.ComputeHash(Encoding.UTF8.GetBytes(contrasenia));
foreach (byte bit in encriptacion)
{
hash = bit.ToString();
}
return hash;
}


  
}
