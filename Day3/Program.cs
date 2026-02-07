/* Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
The overall run time complexity should be O(log (m+n)).

Example 1:

Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.
Example 2:

Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5. */

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        // Garantimos que nums1 seja o menor array para otimizar a busca binária
        if (nums1.Length > nums2.Length)
        {
            return FindMedianSortedArrays(nums2, nums1);
        }

        int m = nums1.Length;
        int n = nums2.Length;
        int low = 0, high = m;

        while (low <= high)
        {
            int partitionX = (low + high) / 2;
            int partitionY = (m + n + 1) / 2 - partitionX;

            // Se partitionX for 0, não há nada à esquerda em nums1 (usamos o menor valor possível)
            // Se partitionX for m, não há nada à direita em nums1 (usamos o maior valor possível)
            double maxLeftX = (partitionX == 0) ? double.MinValue : nums1[partitionX - 1];
            double minRightX = (partitionX == m) ? double.MaxValue : nums1[partitionX];

            double maxLeftY = (partitionY == 0) ? double.MinValue : nums2[partitionY - 1];
            double minRightY = (partitionY == n) ? double.MaxValue : nums2[partitionY];

            if (maxLeftX <= minRightY && maxLeftY <= minRightX)
            {
                // Encontramos o corte perfeito!
                if ((m + n) % 2 == 0)
                {
                    return (Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY)) / 2.0;
                }
                else
                {
                    return Math.Max(maxLeftX, maxLeftY);
                }
            }
            else if (maxLeftX > minRightY)
            {
                // Estamos muito à direita em nums1, precisamos ir para a esquerda
                high = partitionX - 1;
            }
            else
            {
                // Estamos muito à esquerda em nums1, precisamos ir para a direita
                low = partitionX + 1;
            }
        }

        return 0.0; // Caso os arrays não estejam ordenados (não deve acontecer)
    }
}