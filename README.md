# Leet Translator

## Let the n00bz seem k3wl by translating their normal text into L33T.

## Specs (BDD)

### Behavior: A letter of an inputted word will remain unchanged if it is not an "E", "O", "I", or an "S" at the beginning of word.
_Input: "Fat cat nap."_
_Output: "Fat cat nap."_

### Behavior: Each letter "e" will be replaced by the numerical symbol "3".
*_Input: "Blue steel"_
*_Output: "Blu3 st33l"_

### Behavior: Each letter "o" will be replaced by the numerical symbol "0".
*_Input: "Boolean value"_
*_OutputL "B00l3an valu3"_

### Behavior: The capital letter "I" will be replaced by the numerical symbol "1".
*_Input: "I like Indonesian ice cream"_
*_Output: "1 lik3 1nd0n3sian ic3 cr3am"_

### Behavior: The letter "s" shall be replaced with the letter "z" unless it hath the privilege of being the very first-most letter of its word.
*_Input: "Sean Connery always steals the silver screen from six standup citizens in Sioux Falls, South Dakota."_
*_Output: "S3an C0nn3ry alwayz st3alz th3 silv3r scr33n fr0m six standup citiz3nz in Si0ux Fallz, S0uth Dak0ta."_
