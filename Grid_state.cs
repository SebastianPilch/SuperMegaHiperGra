

using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Xaml;
using WPF_giera1;

namespace WPF_giera1
{
    public struct Vertex
    {
        public Vertex(int r, int c)
        {
            Row = r;
            Column = c;
        }
        public int Row { get; }
        public int Column { get; }
    }
    public struct Path_
    {
        public Path_(int d, double c)
        {
            Destination = d;
            path_cost = c;

        }
        public int Destination { get; }
        public double path_cost { get; set; }
    }
    public class Grid_state
    {
        public int Map_size { get; }
        public GridValue [,] Grid { get; set; }

        public Dictionary<int, Vertex> hash_dict = new Dictionary<int, Vertex>();

        public Dictionary<int, List<Path_>> Road_grid = new Dictionary<int, List<Path_>>();

        public Grid_state(int size)
        {
            Map_size = size;
            Grid = new GridValue[size, size];
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {  
                    int Hash_code_to_dict = i * size + j;
                    Vertex new_ver = new Vertex(i, j);
                    hash_dict[Hash_code_to_dict] = new_ver;
                    Grid[i, j] = new GridValue(i, j, new Terrain(0), false, new Unit(1), false, 0);
                    

                }

            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++) 
                { 
                     List<Path_> path_list = new List<Path_>();
                 if ( i == 0) {
                    if (j == 0){
                            path_list.Add(new Path_((i * size + j + 1), 1));

                            path_list.Add(new Path_(((i + 1) * size + j + 1), 1.5));
                            path_list.Add(new Path_(((i + 1) * size + j), 1));
                        }
                    if (j == size - 1)
                        {
                            path_list.Add(new Path_((i * size + j - 1), 1));

                            path_list.Add(new Path_(((i + 1) * size + j - 1), 1.5));
                            path_list.Add(new Path_(((i + 1) * size + j), 1));
                        } 
                    if (j > 0 & j < size - 1)
                        {

                            path_list.Add(new Path_((i * size + j - 1), 1));
                            path_list.Add(new Path_((i * size + j + 1), 1));

                            path_list.Add(new Path_(((i + 1) * size + j + 1), 1.5));
                            path_list.Add(new Path_(((i + 1) * size + j - 1), 1.5));
                            path_list.Add(new Path_(((i + 1) * size + j), 1));
                        } 
                    
                    }
                    if (i == size - 1)
                    {
                        if (j == 0)
                        {
                            path_list.Add(new Path_(((i - 1) * size + j), 1));
                            path_list.Add(new Path_(((i - 1) * size + j + 1), 1.5));

                            path_list.Add(new Path_((i * size + j + 1), 1));

                        }
                        if (j == size - 1)
                        {
                            path_list.Add(new Path_(((i - 1) * size + j - 1), 1.5));
                            path_list.Add(new Path_(((i - 1) * size + j), 1));

                            path_list.Add(new Path_((i * size + j - 1), 1));

                        }
                        if (j > 0 & j < size - 1)
                        {
                            path_list.Add(new Path_(((i - 1) * size + j - 1), 1.5));
                            path_list.Add(new Path_(((i - 1) * size + j), 1));
                            path_list.Add(new Path_(((i - 1) * size + j + 1), 1.5));

                            path_list.Add(new Path_((i * size + j - 1), 1));
                            path_list.Add(new Path_((i * size + j + 1), 1));
                        }

                    }
                    if (i > 0 & i < size-1)
                    {
                        if (j == 0)
                        {
                            path_list.Add(new Path_(((i - 1) * size + j), 1));
                            path_list.Add(new Path_(((i - 1) * size + j + 1), 1.5));

                            path_list.Add(new Path_((i * size + j + 1), 1));

                            path_list.Add(new Path_(((i + 1) * size + j + 1), 1.5));
                            path_list.Add(new Path_(((i + 1) * size + j), 1));
                        }
                        if (j == size - 1)
                        {
                            path_list.Add(new Path_(((i - 1) * size + j - 1), 1.5));
                            path_list.Add(new Path_(((i - 1) * size + j), 1));

                            path_list.Add(new Path_((i * size + j - 1), 1));

                            path_list.Add(new Path_(((i + 1) * size + j - 1), 1.5));
                            path_list.Add(new Path_(((i + 1) * size + j), 1));
                        }
                        if (j > 0 & j < size - 1)
                        {
                            path_list.Add(new Path_(((i - 1) * size + j - 1), 1.5));
                            path_list.Add(new Path_(((i - 1) * size + j), 1));
                            path_list.Add(new Path_(((i - 1) * size + j + 1), 1.5));

                            path_list.Add(new Path_((i * size + j - 1), 1));
                            path_list.Add(new Path_((i * size + j + 1), 1));

                            path_list.Add(new Path_(((i + 1) * size + j + 1), 1.5));
                            path_list.Add(new Path_(((i + 1) * size + j - 1), 1.5));
                            path_list.Add(new Path_(((i + 1) * size + j), 1));

                        }

                    }

                    Road_grid[i*size + j] = path_list;



                }
            }



        }

    }
}


