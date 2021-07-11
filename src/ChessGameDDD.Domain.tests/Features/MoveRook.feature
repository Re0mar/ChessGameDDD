Feature: Move a rook
	A rook piece moving actions on a chess boards

@Rook
Scenario: Moving direction of a rook
	This scenario describes in which direction a rook can move.

	Given there is a board with a rook on 'd5'
	When I want to move the piece on 'd5'
	Then it can be moved in the following directions
	|   | a | b | c | d | e | f | g | h |
	| 1 | . | . | . | x | . | . | . | . |
	| 2 | . | . | . | x | . | . | . | . |
	| 3 | . | . | . | x | . | . | . | . |
	| 4 | . | . | . | x | . | . | . | . |
	| 5 | x | x | x | R | x | x | x | x |
	| 6 | . | . | . | x | . | . | . | . |
	| 7 | . | . | . | x | . | . | . | . |
	| 8 | . | . | . | x | . | . | . | . |