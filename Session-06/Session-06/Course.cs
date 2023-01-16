using System;

public class Course {

	public Guid ID { get; set; }
	public string? Code { get; set; }
	public string? Subject { get; set; }

	public Course() {

	}

	public Course(Guid id) {
		ID = id;
	}

	public Course(Guid id, string code) {
		ID = id;
		Code = code;
	}

	public Course(Guid id, string code, string subject) {
		ID = id;
		Code = code;
		Subject = subject;
	}
}
