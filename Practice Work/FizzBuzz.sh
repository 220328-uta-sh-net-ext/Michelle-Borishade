#! /usr/bin/bash

# this is Michelle's FizzBuzz event!

#For numbers between 1-20, print FIZZ if divisible by 3, BUZZ if divisible by 5, 
# Print FIZZBUZZ if both
read -p "Enter a number " number
if [[ $number -le 0 || $number -gt 20 ]] 
then
        echo Please enter a number 1-20

    else 
        if test $((number % 5)) -eq 0 && test $((number % 3)) -eq 0
            then 
            echo FizzBuzz
        elif test $((number % 5)) -eq 0
            then 
            echo Fizz
        elif test $((number % 3)) -eq 0
            then 
            echo BUZZ
        else
        echo BOOM!
        fi
    fi



