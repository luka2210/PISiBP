// File:    ModelHardverskeKomponenta.cs
// Author:  lukam
// Created: 08 September 2022 17:02:11
// Purpose: Definition of Class ModelHardverskeKomponenta

using System;

public class ModelHardverskeKomponenta
{
   private int idModela;
   private string naziv;
   private string proizvodjac;
   private decimal cena;
   
   public int IdModela
   {
      get
      {
         return idModela;
      }
      set
      {
         this.idModela = value;
      }
   }
   
   public string Naziv
   {
      get
      {
         return naziv;
      }
      set
      {
         this.naziv = value;
      }
   }
   
   public string Proizvodjac
   {
      get
      {
         return proizvodjac;
      }
      set
      {
         this.proizvodjac = value;
      }
   }
   
   public decimal Cena
   {
      get
      {
         return cena;
      }
      set
      {
         this.cena = value;
      }
   }
   
   public System.Collections.Generic.List<HardverskaKomponenta> hardverskaKomponenta;
   
   /// <summary>
   /// Property for collection of HardverskaKomponenta
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<HardverskaKomponenta> HardverskaKomponenta
   {
      get
      {
         if (hardverskaKomponenta == null)
            hardverskaKomponenta = new System.Collections.Generic.List<HardverskaKomponenta>();
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
         this.hardverskaKomponenta = new System.Collections.Generic.List<HardverskaKomponenta>();
      if (!this.hardverskaKomponenta.Contains(newHardverskaKomponenta))
      {
         this.hardverskaKomponenta.Add(newHardverskaKomponenta);
         newHardverskaKomponenta.ModelHardverskeKomponenta = this;
      }
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
         {
            this.hardverskaKomponenta.Remove(oldHardverskaKomponenta);
            oldHardverskaKomponenta.ModelHardverskeKomponenta = null;
         }
   }
   
   /// <summary>
   /// Remove all instances of HardverskaKomponenta from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllHardverskaKomponenta()
   {
      if (hardverskaKomponenta != null)
      {
         System.Collections.ArrayList tmpHardverskaKomponenta = new System.Collections.ArrayList();
         foreach (HardverskaKomponenta oldHardverskaKomponenta in hardverskaKomponenta)
            tmpHardverskaKomponenta.Add(oldHardverskaKomponenta);
         hardverskaKomponenta.Clear();
         foreach (HardverskaKomponenta oldHardverskaKomponenta in tmpHardverskaKomponenta)
            oldHardverskaKomponenta.ModelHardverskeKomponenta = null;
         tmpHardverskaKomponenta.Clear();
      }
   }

}