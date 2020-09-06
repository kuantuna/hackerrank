Regex_Pattern = r"\d\d\D\d\d\D\d\d\d\d"	# Do not delete 'r'.

# \d denotes one digit from 0 to 9
# \D denotes one character that is not a digit

import re

print(str(bool(re.search(Regex_Pattern, input()))).lower())
