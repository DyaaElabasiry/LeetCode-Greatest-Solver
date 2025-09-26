
public class Solution
{
    public int FindPeakElement(int[] nums)
    {
        int l=0,r=nums.Length-1,mid=0;
        if (nums.Length== 1 ) return 0;
        while (l <= r)
        {
            mid = (l + r) / 2;
            if (mid == 0)
            {
                if ( nums[mid]< nums[mid+1 ])
                {
                    mid = mid + 1;
                }
                break;
            }

            if (mid == nums.Length - 1)
            {
                if (  nums[mid] < nums[mid - 1])
                {
                    mid = mid - 1;
                }
                break;
            }

            
            
            if (nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1])
            {
                break;
            }else if (nums[mid] < nums[mid + 1])
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }
        return mid;
    }
}