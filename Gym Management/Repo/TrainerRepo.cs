using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym_Management.Entities;
using Microsoft.Data.SqlClient;

namespace Gym_Management.Repo
{
    
    public class TrainerRepo
    {
        DataAccess dataAccess;
        public TrainerRepo()
        {
            dataAccess = new DataAccess();
        }
        public DataTable Trainers()
        {
            
            SqlCommand cmd = dataAccess.GetCommand("SELECT * FROM TrainerTable");
            return dataAccess.Execute(cmd);
        }
        public int InsertTrainer(Trainer trainer)
        {
            

            SqlCommand cmd = dataAccess.GetCommand(@"INSERT INTO TrainerTable (TrainerName, TrainerPrice)
                       VALUES (@name, @price)");
            cmd.Parameters.AddWithValue("@name", trainer.TrainerName);
            cmd.Parameters.AddWithValue("@price", trainer.TrainerPrice);

            return dataAccess.ExecuteNonQuery(cmd);
        }

        public int UpdateTrainer(Trainer trainer)
        {
            

            SqlCommand cmd = dataAccess.GetCommand(@"UPDATE TrainerTable
                       SET TrainerName = @name, 
                           TrainerPrice = @price 
                       WHERE TrainerId = @trainerid");
            cmd.Parameters.AddWithValue("@trainerid", trainer.TrainerId);
            cmd.Parameters.AddWithValue("@name", trainer.TrainerName);
            cmd.Parameters.AddWithValue("@price", trainer.TrainerPrice);

            return dataAccess.ExecuteNonQuery(cmd);
        }

        public int DeleteTrainer(int trainerId)
        {
            
            SqlCommand cmd = dataAccess.GetCommand("DELETE FROM TrainerTable WHERE TrainerId = @trainerid");
            cmd.Parameters.AddWithValue("@trainerid", trainerId);

            return dataAccess.ExecuteNonQuery(cmd);
        }


    }
}
