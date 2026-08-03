func removeElement(nums []int, val int) int {
	var count int = -1

	for i := 0; i < len(nums); i++ {
		if nums[i] == val {
			if count == -1 {
				count = i
			}
		} else if count != -1 {
			nums[count] = nums[i]
			count++
		}
	}

	if count == -1 {
		return len(nums)
	}

	return count
}