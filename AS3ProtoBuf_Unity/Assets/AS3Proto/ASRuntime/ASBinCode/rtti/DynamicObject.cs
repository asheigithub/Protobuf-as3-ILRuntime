﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ASBinCode.rtti
{
    public class DynamicObject : Object
    {
        protected Dictionary<string, SLOT> propertys;

        public rtti.DynamicObject _prototype_;

        public DynamicObject(Class _class):base(_class)
        {
            propertys = new Dictionary<string, SLOT>();
        }

        public SLOT this[string name]
        {
            get
            {
                return propertys[name];
            }
        }

        public bool hasproperty(string name)
        {
            return propertys.ContainsKey(name);
        }

        public bool propertyIsEnumerable(string name)
        {
            var slot = propertys[name];
            if (slot is ILinkSlot)
            {
                return ((ILinkSlot)slot).propertyIsEnumerable;
            }
            else
            {
                return false;
            }

        }

        public void setPropertyIsEnumerable(string name,bool isEnum)
        {
            var slot = propertys[name];
            if (slot is ILinkSlot)
            {
                ((ILinkSlot)slot).propertyIsEnumerable = isEnum;
            }
            
        }



        private ILinkSlot rootSlot;

        public IEnumerator<ILinkSlot> eachSlot()
        {
            var root = rootSlot;

            while(root !=null)
            {
                if (root.propertyIsEnumerable && !root.isDeleted )
                {
                    yield return root;
                }
                root = root.nextSlot;
            }
            yield break;
        }


        public void createproperty(string name,ILinkSlot slot)
        {
            if (!propertys.ContainsKey(name))
            {
                propertys.Add(name, (SLOT)slot);

                if (rootSlot == null)
                {
                    rootSlot = slot;
                }
                else
                {
                    rootSlot.preSlot = slot;
                    slot.nextSlot = rootSlot;
                    rootSlot = slot;

                }

            }
        }

        //public void createOrReplaceproperty(string name, ILinkSlot slot)
        //{
        //    if (!propertys.ContainsKey(name))
        //    {
        //        propertys.Add(name, slot);

                
        //        if (rootSlot == null)
        //        {
        //            rootSlot = slot;
        //        }
        //        else
        //        {
        //            rootSlot.preSlot = slot;
        //            slot.nextSlot = rootSlot;
        //            rootSlot = slot;

        //        }

        //    }
        //    else
        //    {
        //        ISLOT oldslot = propertys[name];
        //        propertys[name] = slot;

                

        //    }
        //}



        public void deleteProperty(string name)
        {
            if (propertys.ContainsKey(name))
            {
                SLOT slot = propertys[name];
                propertys.Remove(name);

                ILinkSlot ls = slot as ILinkSlot;
                if (ls != null)
                {
                    ls.isDeleted = true;
                    if (ls.preSlot != null)
                    {
                        ls.preSlot.nextSlot = ls.nextSlot;

                        if (ls.nextSlot != null)
                        {
                            ls.nextSlot.preSlot = ls.preSlot;
                        }

                        ls.preSlot = null;
                    }
                    else
                    {
                        if (ls.nextSlot != null)
                        {
                            ls.nextSlot.preSlot = null;
                        }
                    }

                }

            }
        }

    }
}
