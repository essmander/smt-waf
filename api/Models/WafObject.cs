using System;

namespace WAFApi.Models
{
    public record WafObject
    {
        public string SiteNamne { get; init; }
        public string Hotel { get; init; }
        public string Environment { get; init; }
        public string UGUser { get; init; }
        public string Nets { get; init; }
        public string AppUser { get; init; }
        public string AppUserPW { get; init; }

      //  public WafObject(string siteNamne, string hotel, string environment, string uGUser, string nets, string appUser, string appUserPW)
      //=> (SiteNamne, Hotel, Environment, UGUser, Nets, AppUser, AppUserPW) = (siteNamne, hotel, environment, uGUser, nets, appUser, appUserPW);
      //  public void Deconstruct(out string siteName, out string hotel, out string environment, out string uGUser, out string nets, out string appUser, out string appUserPW)
      //  {
      //      (siteName, hotel, environment, uGUser, nets, appUser, appUserPW) = (SiteNamne, Hotel, Environment, UGUser, Nets, AppUser, AppUserPW);
      //  }
    }
}