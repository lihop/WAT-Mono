extends Reference
class_name WAT

const TestDoubleFactory = preload("res://addons/WAT/core/double/factory.gd")
const Test: Script = preload("res://addons/WAT/core/test/test.gd")
const Results: Resource = preload("res://addons/WAT/resources/results.tres")
const TestSuiteOfSuites = preload("res://addons/WAT/core/test/suite.gd")
const TestCase = preload("res://addons/WAT/core/test/case.gd")


class Icon:
	const SUCCESS = preload("res://addons/WAT/assets/success.png")
	const FAILED = preload("res://addons/WAT/assets/failed.png")
	const SUPPORT = preload("res://addons/WAT/assets/kofi.png")
