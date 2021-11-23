using System.Collections.Generic;
using FizHoje.Data;
using FizHoje.Models;

namespace MockFizHoje.Data
{
    public class MockFizHojeRepo : IFizHojeRepo
    {
        public void CreateFizHoje(FizHojeModel fizHoje)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteFizHoje(FizHojeModel fizHoje)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<FizHojeModel> GetAllFizHoje()
        {
            var fizHojeLista = new List<FizHojeModel>{
                new FizHojeModel{
                    Id = 0,
                    TaFeito = true,
                    DataFeito = "2021-11-22 22:50"
                },
                new FizHojeModel{
                    Id = 1,
                    TaFeito = false,
                    DataFeito = "2021-11-22 22:53"
                },
                new FizHojeModel{
                    Id = 2,
                    TaFeito = true,
                    DataFeito = "2021-11-22 22:56"
                }
            };

            return fizHojeLista;
        }

        public FizHojeModel GetFizHojeById(int id)
        {
            return new FizHojeModel{
                Id = 0,
                TaFeito = true,
                DataFeito = "2021-11-22 22:57"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateFizHoje(FizHojeModel fizHoje)
        {
            throw new System.NotImplementedException();
        }
    }
}