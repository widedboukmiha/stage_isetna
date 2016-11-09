using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_des_Stage_ISET_CHARGUIA.Business
{
    class Stage
    {
        private String date_debut_stage;
        private String date_fin_stage;
        private String typeStage;
        private String id_stage;

        public Stage(String id_stage,String date_debut_stage, String date_fin_stage, String typeStage)
        {

            this.id_stage = id_stage;
            this.date_debut_stage = date_debut_stage;
            this.date_fin_stage = date_fin_stage;
            this.typeStage = typeStage;
            
			
        }
        public String getDate_debut_stage()
        {
            return date_debut_stage;
        }

        public String getDate_fin_stage()
        {
            return date_fin_stage;
        }

        public String getTypeStage()
        {
            return typeStage;
        }

        public String getId_stage()
        {
            return id_stage;
        }

        public void setId_stage(String id_stage)
        {
            this.id_stage = id_stage;
        }

        public void setTypeStage(String typeStage)
        {
            this.typeStage=typeStage;
        }

        public void setdate_debut_stage(String date_debut_stage)
        {
            this.date_debut_stage=date_debut_stage;
        }

          public void setdate_fin_stage(String date_fin_stage)
        {
            this.date_fin_stage=date_fin_stage;
        }

        public String toString()
        {
            return "id :" + id_stage + "date début stage " + date_debut_stage + " date fin stage " + date_fin_stage + " type de stage " + typeStage;+
        }



    }
}
