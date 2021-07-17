Feature: Board
	This feature describes the functions of the board.

Scenario: Get all pieces in between two locations
	This scnerio describes how the board identifies all pieces between two locations

	Given the board has the following setup
		|   | a | b | c | d | e | f | g | h |
		| 1 | . | . | . | x | . | . | . | . |
		| 2 | . | . | . | P | . | . | . | . |
		| 3 | . | . | . | x | . | . | . | . |
		| 4 | . | . | . | x | . | . | . | . |
		| 5 | x | x | x | R | x | x | x | x |
		| 6 | . | . | . | x | . | . | . | . |
		| 7 | . | . | . | x | . | . | . | . |
		| 8 | . | . | . | x | . | . | . | . |
	