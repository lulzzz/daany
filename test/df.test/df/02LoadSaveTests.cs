using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;
using Daany;

namespace Unit.Test.DF
{
    public class LoadSaveTests
    {

        [Fact]
        public void LoadromCSV_Test()
        {
            string path = "../../../testdata/titanic_full_1310.csv";
            var df = DataFrame.FromCsv(path, '\t', names:null); //
            //row test
            var r1 = df[393].ToList();

            //2	0	Denbury Mr. Herbert	male	25	0	0	C.A. 31029	31.5000		S		
            var e1 = new object[] { 2, 0, "Denbury Mr. Herbert", "male", 25, 0, 0, "C.A. 31029", "31.5",DataFrame.NAN, "S", DataFrame.NAN, DataFrame.NAN, "Guernsey / Elizabeth NJ"};


            for (int i = 0; i < e1.Length; i++)
            {
                if (r1[i] == null)
                {
                    Assert.Null(r1[i]);
                    Assert.Null(e1[i]);
                }

                else
                {
                    object v1 = r1[i].ToString();
                    object v2 = e1[i].ToString();
                    Assert.True(v1.Equals(v2));
                }

            }
        }

        [Fact]
        public void LoadromCSV_Test2()
        {
            string path = "../../../testdata/titanic_train.csv";
            var df = DataFrame.FromCsv(path, ',', names: null); //

            //
            //row test
            var r1 = df[0].ToList();
            //1,0,3,Braund Mr. Owen Harris,male,22,1,0,A/5 21171,7.25,,S,youth		
            var e1 = new object[] { 1, 0, 3, "Braund Mr. Owen Harris", "male", 22, 1, 0, "A/5 21171", 7.25, DataFrame.NAN ,"S", "youth" };


            for (int i = 0; i < e1.Length; i++)
            {
                if(r1[i]==null)
                {
                    Assert.Null(r1[i]);
                    Assert.Null(e1[i]);
                }

                else
                {
                    object v1 = r1[i].ToString();
                    object v2 = e1[i].ToString();
                    Assert.True(v1.Equals(v2));
                }
                
            }
        }


        [Fact]
        public void SaveToCSV_Test()
        {
            
        }

    }
}