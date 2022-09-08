// File:    GrafickaKartica.cs
// Author:  lukam
// Created: 08 September 2022 17:02:11
// Purpose: Definition of Class GrafickaKartica

using System;

public class GrafickaKartica : ModelHardverskeKomponenta
{
   private string radnaMemorija;
   private string maxTemp;
   
   public string RadnaMemorija
   {
      get
      {
         return radnaMemorija;
      }
      set
      {
         this.radnaMemorija = value;
      }
   }
   
   public string MaxTemp
   {
      get
      {
         return maxTemp;
      }
      set
      {
         this.maxTemp = value;
      }
   }

}