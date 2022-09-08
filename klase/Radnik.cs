// File:    Radnik.cs
// Author:  lukam
// Created: 08 September 2022 17:02:11
// Purpose: Definition of Class Radnik

using System;

public class Radnik : Nalog
{
   private decimal brojUgovora;
   private decimal plata;
   
   public decimal BrojUgovora
   {
      get
      {
         return brojUgovora;
      }
      set
      {
         this.brojUgovora = value;
      }
   }
   
   public decimal Plata
   {
      get
      {
         return plata;
      }
      set
      {
         this.plata = value;
      }
   }
   
   public System.Collections.ArrayList zahtevZaServisiranje;
   
   /// <summary>
   /// Property for collection of ZahtevZaServisiranje
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.ArrayList ZahtevZaServisiranje
   {
      get
      {
         if (zahtevZaServisiranje == null)
            zahtevZaServisiranje = new System.Collections.ArrayList();
         return zahtevZaServisiranje;
      }
      set
      {
         RemoveAllZahtevZaServisiranje();
         if (value != null)
         {
            foreach (ZahtevZaServisiranje oZahtevZaServisiranje in value)
               AddZahtevZaServisiranje(oZahtevZaServisiranje);
         }
      }
   }
   
   /// <summary>
   /// Add a new ZahtevZaServisiranje in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddZahtevZaServisiranje(ZahtevZaServisiranje newZahtevZaServisiranje)
   {
      if (newZahtevZaServisiranje == null)
         return;
      if (this.zahtevZaServisiranje == null)
         this.zahtevZaServisiranje = new System.Collections.ArrayList();
      if (!this.zahtevZaServisiranje.Contains(newZahtevZaServisiranje))
         this.zahtevZaServisiranje.Add(newZahtevZaServisiranje);
   }
   
   /// <summary>
   /// Remove an existing ZahtevZaServisiranje from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveZahtevZaServisiranje(ZahtevZaServisiranje oldZahtevZaServisiranje)
   {
      if (oldZahtevZaServisiranje == null)
         return;
      if (this.zahtevZaServisiranje != null)
         if (this.zahtevZaServisiranje.Contains(oldZahtevZaServisiranje))
            this.zahtevZaServisiranje.Remove(oldZahtevZaServisiranje);
   }
   
   /// <summary>
   /// Remove all instances of ZahtevZaServisiranje from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllZahtevZaServisiranje()
   {
      if (zahtevZaServisiranje != null)
         zahtevZaServisiranje.Clear();
   }

}