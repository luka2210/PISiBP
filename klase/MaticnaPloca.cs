// File:    MaticnaPloca.cs
// Author:  lukam
// Created: 08 September 2022 17:02:11
// Purpose: Definition of Class MaticnaPloca

using System;

public class MaticnaPloca : ModelHardverskeKomponenta
{
   private string brzinaRamMemorije;
   private string brojUsbPortova;
   
   public string BrzinaRamMemorije
   {
      get
      {
         return brzinaRamMemorije;
      }
      set
      {
         this.brzinaRamMemorije = value;
      }
   }
   
   public string BrojUsbPortova
   {
      get
      {
         return brojUsbPortova;
      }
      set
      {
         this.brojUsbPortova = value;
      }
   }

}