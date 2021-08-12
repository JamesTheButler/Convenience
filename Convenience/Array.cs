using System.Drawing;

namespace Convenience {
    public static class Array {
        public static T[,] CreateArray<T>(Size arraySize) {
            return new T[arraySize.Width, arraySize.Height];
        }

        public static T[,] FillArray<T>(T[,] array, T value) {
            for (int i = 0; i < array.GetLength(0); i++) {
                for (int j = 0; j < array.GetLength(1); j++) {
                    array[i, j] = value;
                }
            }
            return array;
        }

        public static T[,] FillRow<T>(T[,] array, int rowId, T value) {
            if (rowId >= array.GetLength(1)) { return array; }

            for (int i = 0; i < array.GetLength(0); i++) {
                array[i, rowId] = value;
            }
            return array;
        }

        public static T[,] FillColumn<T>(T[,] array, int columnId, T value) {
            if (columnId >= array.GetLength(0)) { return array; }

            for (int j = 0; j < array.GetLength(1); j++) {
                array[columnId, j] = value;
            }
            return array;
        }

        public static string ToString<T>(T[,] array) {
            string s = "";
            for (int i = 0; i < array.GetLength(0); i++) {
                for (int j = 0; j < array.GetLength(1); j++) {
                    s += array[i, j].ToString() + "\t";
                }
                s += "\n";
            }
            return s;
        }
    }
}
