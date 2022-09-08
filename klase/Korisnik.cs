// File:    Korisnik.cs
// Author:  lukam
// Created: 08 September 2022 17:02:11
// Purpose: Definition of Class Korisnik

using System;

public class Korisnik : Nalog
{
   public System.Collections.ArrayList hardverskaKomponenta;
   
   /// <summary>
   /// Property for collection of HardverskaKomponenta
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.ArrayList HardverskaKomponenta
   {
      get
      {
         if (hardverskaKomponenta == null)
            hardverskaKomponenta = new System.Collections.ArrayList();
         return hardverskaKomponenta;
      }
      set
      {
         RemoveAllHardverskaKomponenta();
         if (value != null)
         {
            foreach (HardverskaKomponenta oHardverskaKomponenta in value)
               AddHardverskaKomponenta(oHardverskaKomponenta);
         }
      }
   }
   
   /// <summary>
   /// Add a new HardverskaKomponenta in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddHardverskaKomponenta(HardverskaKomponenta newHardverskaKomponenta)
   {
      if (newHardverskaKomponenta == null)
         return;
      if (this.hardverskaKomponenta == null)
         this.hardverskaKomponenta = new System.Collections.ArrayList();
      if (!this.hardverskaKomponenta.Contains(newHardverskaKomponenta))
         this.hardverskaKomponenta.Add(newHardverskaKomponenta);
   }
   
   /// <summary>
   /// Remove an existing HardverskaKomponenta from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveHardverskaKomponenta(HardverskaKomponenta oldHardverskaKomponenta)
   {
      if (oldHardverskaKomponenta == null)
         return;
      if (this.hardverskaKomponenta != null)
         if (this.hardverskaKomponenta.Contains(oldHardverskaKomponenta))
            this.hardverskaKomponenta.Remove(oldHardverskaKomponenta);
   }
   
   /// <summary>
   /// Remove all instances of HardverskaKomponenta from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllHardverskaKomponenta()
   {
      if (hardverskaKomponenta != null)
         hardverskaKomponenta.Clear();
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