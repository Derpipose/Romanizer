Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@mytag
Scenario: Simple 2000
	Given input of 2000
	When converted to Roman numerals
	Then the result should be MM

	Scenario: Simple 5
	Given input of 5
	When converted to Roman numerals
	Then the result should be V


Scenario Outline: List numbers
	Given our input is <interger>
	When converted to Roman numerals
	Then the result should be <Romanized>

	Examples:

    | interger	| Romanized	|
    | 3			| III		|
    | 4			| IV		|
    | 5			| V			|
    | 6			| VI		|
    | 8			| VIII 		|
    | 9 		| IX 		|
    | 10  		| X	    	|
    | 11		| XI		|
    | 27		| XXVII		|
    | 29		| XXIX 		|
    | 30		| XXX		|
    | 31		| XXXI		|
    | 777		| DCCLXXVII		|
    | 999		| CMXCIX		|
    | 1999		| MCMXCIX		|
    | 2021		| MMXXI		|
    | 4000		| *error*		|
    | 0			| 		|
