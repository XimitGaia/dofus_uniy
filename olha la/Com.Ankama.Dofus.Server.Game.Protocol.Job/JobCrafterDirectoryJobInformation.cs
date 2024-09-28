using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x200037B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobCrafterDirectoryJobInformation : IMessage<JobCrafterDirectoryJobInformation>, IMessage, IEquatable<JobCrafterDirectoryJobInformation>, IDeepCloneable<JobCrafterDirectoryJobInformation>, IBufferMessage
{
	[Token(Token = "0x4000C00")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobCrafterDirectoryJobInformation> _parser;

	[Token(Token = "0x4000C01")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C02")]
	public const int JobIdFieldNumber = 1;

	[Token(Token = "0x4000C03")]
	[FieldOffset(Offset = "0x18")]
	private int jobId_;

	[Token(Token = "0x4000C04")]
	public const int JobLevelFieldNumber = 2;

	[Token(Token = "0x4000C05")]
	[FieldOffset(Offset = "0x1C")]
	private int jobLevel_;

	[Token(Token = "0x4000C06")]
	public const int FreeFieldNumber = 3;

	[Token(Token = "0x4000C07")]
	[FieldOffset(Offset = "0x20")]
	private bool free_;

	[Token(Token = "0x4000C08")]
	public const int MinLevelFieldNumber = 4;

	[Token(Token = "0x4000C09")]
	[FieldOffset(Offset = "0x24")]
	private int minLevel_;

	[Token(Token = "0x170007BB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JobCrafterDirectoryJobInformation> Parser
	{
		[Token(Token = "0x600240E")]
		[Address(RVA = "0x989B90", Offset = "0x988F90", VA = "0x180989B90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007BC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600240F")]
		[Address(RVA = "0x989AE0", Offset = "0x988EE0", VA = "0x180989AE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007BD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002410")]
		[Address(RVA = "0x989DA0", Offset = "0x9891A0", VA = "0x180989DA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007BE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int JobId
	{
		[Token(Token = "0x6002414")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002415")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170007BF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int JobLevel
	{
		[Token(Token = "0x6002416")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002417")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170007C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Free
	{
		[Token(Token = "0x6002418")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002419")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x170007C1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MinLevel
	{
		[Token(Token = "0x600241A")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600241B")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x6002411")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobCrafterDirectoryJobInformation()
	{
	}

	[Token(Token = "0x6002412")]
	[Address(RVA = "0x989A80", Offset = "0x988E80", VA = "0x180989A80")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobCrafterDirectoryJobInformation(JobCrafterDirectoryJobInformation other)
	{
	}

	[Token(Token = "0x6002413")]
	[Address(RVA = "0x989640", Offset = "0x988A40", VA = "0x180989640", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobCrafterDirectoryJobInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x600241C")]
	[Address(RVA = "0x989720", Offset = "0x988B20", VA = "0x180989720", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600241D")]
	[Address(RVA = "0x9896D0", Offset = "0x988AD0", VA = "0x1809896D0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(JobCrafterDirectoryJobInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x600241E")]
	[Address(RVA = "0x9897C0", Offset = "0x988BC0", VA = "0x1809897C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600241F")]
	[Address(RVA = "0x989920", Offset = "0x988D20", VA = "0x180989920", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002420")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002421")]
	[Address(RVA = "0x989CE0", Offset = "0x9890E0", VA = "0x180989CE0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002422")]
	[Address(RVA = "0x989550", Offset = "0x988950", VA = "0x180989550", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002423")]
	[Address(RVA = "0x9898B0", Offset = "0x988CB0", VA = "0x1809898B0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(JobCrafterDirectoryJobInformation other)
	{
	}

	[Token(Token = "0x6002424")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002425")]
	[Address(RVA = "0x989BE0", Offset = "0x988FE0", VA = "0x180989BE0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
