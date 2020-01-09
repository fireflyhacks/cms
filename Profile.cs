using System;

namespace CMS
{
    
    public class Profile
    {
    
        private String name; 
        private String medicaidID;
        private String address;
        private String hPhone; 
        private String cPhone;
        private String pricarephys;
        private String psychNameNum;
        private String theraNameNum;
        private String specialistInfo;
        private String emergencyNameNum;
        private String hhPlus;
        private String harpHcbs;
        private String enrollCode;
        private String goals;
        private String status;
        private String enrollDate;

        //=[CONSTRUCTOR]==========================================================================================================//

        public Profile(String nam, String med, String add, String hom, String cel, String pcp, String psy, String thp, String spc, 
                       String emc, String hhp, String hrp, String ecd, String gls, String sts, String edt)
                       {

                           name =             nam;
                           medicaidID =       med;
                           address =          add;
                           hPhone =           hom;
                           cPhone =           cel;
                           pricarephys =      pcp;
                           psychNameNum =     psy;
                           theraNameNum =     thp;
                           specialistInfo =   spc;
                           emergencyNameNum = emc;
                           hhPlus =           hhp;
                           harpHcbs =         hrp;
                           enrollCode =       ecd;
                           goals =            gls;
                           status =           sts;
                           enrollDate =       edt; 

                       }

        //=[GETTERS & SETTERS]====================================================================================================//

        ////////////////////////////////////////////// NAME
        public void setName(String s)
        {
            this.name = s;
        }
        public String getName()
        {
            return this.name;
        }
        ////////////////////////////////////////////// MEDICAID ID
        public void setMedicaidID(String s)
        {
            this.medicaidID = s;
        }
        public String getMedicaidID()
        {
            return this.medicaidID;
        }
        ////////////////////////////////////////////// ADDRESS
        public void setAddress(String s)
        {
            this.address = s;
        }
        public String getAddress()
        {
            return this.address;
        }
        ////////////////////////////////////////////// HOME PHONE
        public void setHomePhone(String s)
        {
            this.hPhone = s;
        }
        public String getHomePhone()
        {
            return this.hPhone;
        }
        ////////////////////////////////////////////// CELL PHONE
        public void setCellPhone(String s)
        {
           this.cPhone = s;
        }
        public String getCellPhone()
        {
            return this.cPhone;
        }
        ////////////////////////////////////////////// PRIMARY CARE PHYS
        public void setPCP(String s)
        {
            this.pricarephys = s;
        }
        public String getPCP()
        {
            return this.pricarephys;
        }
        ////////////////////////////////////////////// PSYCHIATRIST INFO
        public void setPsychNameNum(String s)
        {
            this.psychNameNum = s;
        }
        public String getPsychNameNum()
        {
            return this.psychNameNum;
        }
        ////////////////////////////////////////////// THERAPIST INFO
        public void setTherapistNameNum(String s)
        {
            this.theraNameNum = s;
        }
        public String getTherapistNameNum()
        {
            return this.theraNameNum;
        }
        ////////////////////////////////////////////// SPECIALIST INFO
        public void setSpecialistInfo(String s)
        {
            this.specialistInfo = s;
        }
        public String getSpecialistInfo()
        {
            return this.specialistInfo;
        }
        ////////////////////////////////////////////// EMERGENCY CONTACT
        public void setEmergencyNameNum(String s)
        {
            this.emergencyNameNum = s;
        }
        public String getEmergencyNameNum()
        {
            return this.emergencyNameNum;
        }
        ////////////////////////////////////////////// HH+
        public void setHHPlus(String s)
        {
            this.hhPlus = s;
        }
        public String getHHPlus()
        {
            return this.hhPlus;
        }
        ////////////////////////////////////////////// HARP/HCBS
        public void setHarpHCBS(String s)
        {
            this.harpHcbs = s;
        }
        public String getHarpHCBS()
        {
            return this.harpHcbs;
        }
        ////////////////////////////////////////////// ENROLLMENT CODE
        public void setEnrollCode(String s)
        {
            this.enrollCode = s;
        }
        public String getEnrollCode()
        {
            return this.enrollCode;
        }
        ////////////////////////////////////////////// GOALS
        public void setGoals(String s)
        {
            this.goals = s;
        }
        public String getGoals()
        {
            return this.goals;
        }
        ////////////////////////////////////////////// STATUS
        public void setStatus(String s)
        {
            this.status = s;
        }
        public String getStatus()
        {
            return this.status;
        }
        ////////////////////////////////////////////// ENROLLMENT DATE
        public void setEnrollDate(String s)
        {
            this.enrollDate = s;
        }
        public String getEnrollDate()
        {
            return this.enrollDate;
        }

    }
}