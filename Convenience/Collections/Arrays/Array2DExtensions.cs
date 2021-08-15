namespace Convenience.Collections.Arrays {
    public static class Array2DExtensions {
        public static void FillArray<T>(this T[,] array, T value) {
            Array2DUtility.FillArray(array, value);
        }

        public static void FillRow<T>(this T[,] array, int rowId, T value) {
            Array2DUtility.FillRow(array, rowId, value);
        }

        public static void FillColumn<T>(this T[,] array, int columnId, T value) {
            Array2DUtility.FillColumn(array, columnId, value);
        }

        public static string ToString<T>(this T[,] array) {
            return Array2DUtility.ToString(array);
        }
    }
}
