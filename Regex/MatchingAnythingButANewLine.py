regex_pattern = r"...\....\....\....$"	# Do not delete 'r'.

# It should have a dollar sign at the end because if not, the string "abc.def.ghi.jklM" would also be valid, but we want 3 characters after the last dot.

import re
import sys

test_string = input()

match = re.match(regex_pattern, test_string) is not None

print(str(match).lower())

