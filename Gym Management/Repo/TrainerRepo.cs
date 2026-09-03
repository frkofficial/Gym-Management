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
        public List<TrainerDto> GetActiveTrainers()
        {
            var list = new List<TrainerDto>();
            SqlCommand cmd = dataAccess.GetCommand(
                "SELECT TrainerId, TrainerName, TrainerPrice, Specialization, Rating " +
                "FROM TrainerTable WHERE IsActive = 1");
            DataTable dt = dataAccess.Execute(cmd);

            foreach (DataRow row in dt.Rows)
            {
                decimal.TryParse(row["TrainerPrice"]?.ToString() ?? "0", out var rate);
                var t = new TrainerDto
                {
                    Id = Convert.ToInt32(row["TrainerId"]),
                    FullName = row["TrainerName"]?.ToString() ?? "",
                    HourlyRate = rate,
                    Specialization = row["Specialization"] == DBNull.Value ? "General Trainer" : row["Specialization"].ToString(),
                    Rating = row["Rating"] == DBNull.Value ? 5.0m : Convert.ToDecimal(row["Rating"]),
                    ShiftNames = GetShiftNamesForTrainer(Convert.ToInt32(row["TrainerId"]))
                };
                list.Add(t);
            }
            return list;
        }

        private List<string> GetShiftNamesForTrainer(int trainerId)
        {
            var shifts = new List<string>();
            SqlCommand cmd = dataAccess.GetCommand(
                "SELECT DISTINCT ShiftName FROM TrainerAvailability WHERE TrainerId = @tid AND ShiftName IS NOT NULL");
            cmd.Parameters.AddWithValue("@tid", trainerId);
            DataTable dt = dataAccess.Execute(cmd);
            foreach (DataRow row in dt.Rows)
                shifts.Add(row["ShiftName"].ToString());
            return shifts;
        }

        public List<string> GetAvailableDaysForTrainer(int trainerId)
        {
            var days = new List<string>();
            SqlCommand cmd = dataAccess.GetCommand(
                "SELECT DISTINCT DayOfWeek FROM TrainerAvailability WHERE TrainerId = @tid");
            cmd.Parameters.AddWithValue("@tid", trainerId);
            DataTable dt = dataAccess.Execute(cmd);
            foreach (DataRow row in dt.Rows)
                days.Add(row["DayOfWeek"].ToString());
            return days;
        }

        public List<SlotDto> GetSlotsForTrainerAndDay(int trainerId, string day)
        {
            var slots = new List<SlotDto>();
            SqlCommand cmd = dataAccess.GetCommand(
                "SELECT SlotId, SlotTime, IsBooked FROM TrainerSlots " +
                "WHERE TrainerId = @tid AND DayOfWeek = @day ORDER BY SlotTime");
            cmd.Parameters.AddWithValue("@tid", trainerId);
            cmd.Parameters.AddWithValue("@day", day);
            DataTable dt = dataAccess.Execute(cmd);
            foreach (DataRow row in dt.Rows)
            {
                slots.Add(new SlotDto
                {
                    Id = Convert.ToInt32(row["SlotId"]),
                    SlotTime = (TimeSpan)row["SlotTime"],
                    IsBooked = Convert.ToBoolean(row["IsBooked"])
                });
            }
            return slots;
        }


    }
}
