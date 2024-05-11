// 37087589008
// 370.875.890-08 -- Dont Work
// ***.875.890-**
// string cpf = "***.875.890-**";
// string formattedCpf = MascaraCpf(cpf);
// Console.WriteLine(formattedCpf);

// static string MascaraCpf(string pCPF)
// {
//   if (string.IsNullOrEmpty(pCPF))
//   {
//     return string.Empty;
//   }

//   if (pCPF.Length != 11)
//     return pCPF;
//   else
//     return "***" + "." + pCPF.Substring(3, 3) + "." + pCPF.Substring(6, 3) + "-" + "**";
// }

class Program
{
  private static void Main(string[] args)
  {
    // 37087589008
    // 370.875.890-08 -- Dont Work
    // ***.875.890-**
    string cpf = "***.875.890-**";
    string formattedCpf = MascaraCpf(cpf);
    Console.WriteLine(formattedCpf);
  }
  static string MascaraCpf(string pCPF)
  {
    if (string.IsNullOrEmpty(pCPF))
    {
      return string.Empty;
    }

    if (pCPF.Length != 11)
      return pCPF;
    else
      return "***" + "." + pCPF.Substring(3, 3) + "." + pCPF.Substring(6, 3) + "-" + "**";
  }
}
