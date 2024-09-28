using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x2000375")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobExperience : IMessage<JobExperience>, IMessage, IEquatable<JobExperience>, IDeepCloneable<JobExperience>, IBufferMessage
{
	[Token(Token = "0x4000BD7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobExperience> _parser;

	[Token(Token = "0x4000BD8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000BD9")]
	public const int JobIdFieldNumber = 1;

	[Token(Token = "0x4000BDA")]
	[FieldOffset(Offset = "0x18")]
	private int jobId_;

	[Token(Token = "0x4000BDB")]
	public const int JobLevelFieldNumber = 2;

	[Token(Token = "0x4000BDC")]
	[FieldOffset(Offset = "0x1C")]
	private int jobLevel_;

	[Token(Token = "0x4000BDD")]
	public const int JobXpFieldNumber = 3;

	[Token(Token = "0x4000BDE")]
	[FieldOffset(Offset = "0x20")]
	private long jobXp_;

	[Token(Token = "0x4000BDF")]
	public const int JobXpLevelFloorFieldNumber = 4;

	[Token(Token = "0x4000BE0")]
	[FieldOffset(Offset = "0x28")]
	private long jobXpLevelFloor_;

	[Token(Token = "0x4000BE1")]
	public const int JobXpNextLevelFloorFieldNumber = 5;

	[Token(Token = "0x4000BE2")]
	[FieldOffset(Offset = "0x30")]
	private long jobXpNextLevelFloor_;

	[Token(Token = "0x170007A2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<JobExperience> Parser
	{
		[Token(Token = "0x60023B2")]
		[Address(RVA = "0x972940", Offset = "0x971D40", VA = "0x180972940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007A3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60023B3")]
		[Address(RVA = "0x972890", Offset = "0x971C90", VA = "0x180972890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007A4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60023B4")]
		[Address(RVA = "0x972B90", Offset = "0x971F90", VA = "0x180972B90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007A5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int JobId
	{
		[Token(Token = "0x60023B8")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60023B9")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170007A6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int JobLevel
	{
		[Token(Token = "0x60023BA")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60023BB")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170007A7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long JobXp
	{
		[Token(Token = "0x60023BC")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60023BD")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170007A8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long JobXpLevelFloor
	{
		[Token(Token = "0x60023BE")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60023BF")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x170007A9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long JobXpNextLevelFloor
	{
		[Token(Token = "0x60023C0")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60023C1")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x60023B5")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobExperience()
	{
	}

	[Token(Token = "0x60023B6")]
	[Address(RVA = "0x972820", Offset = "0x971C20", VA = "0x180972820")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobExperience(JobExperience other)
	{
	}

	[Token(Token = "0x60023B7")]
	[Address(RVA = "0x9723C0", Offset = "0x9717C0", VA = "0x1809723C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobExperience Clone()
	{
		return null;
	}

	[Token(Token = "0x60023C2")]
	[Address(RVA = "0x972460", Offset = "0x971860", VA = "0x180972460", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60023C3")]
	[Address(RVA = "0x972510", Offset = "0x971910", VA = "0x180972510", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(JobExperience other)
	{
		return default(bool);
	}

	[Token(Token = "0x60023C4")]
	[Address(RVA = "0x972560", Offset = "0x971960", VA = "0x180972560", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60023C5")]
	[Address(RVA = "0x9726C0", Offset = "0x971AC0", VA = "0x1809726C0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60023C6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60023C7")]
	[Address(RVA = "0x972AB0", Offset = "0x971EB0", VA = "0x180972AB0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60023C8")]
	[Address(RVA = "0x972280", Offset = "0x971680", VA = "0x180972280", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60023C9")]
	[Address(RVA = "0x972640", Offset = "0x971A40", VA = "0x180972640", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(JobExperience other)
	{
	}

	[Token(Token = "0x60023CA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60023CB")]
	[Address(RVA = "0x972990", Offset = "0x971D90", VA = "0x180972990", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
