using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009ED")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SocialApplicationInformation : IMessage<SocialApplicationInformation>, IMessage, IEquatable<SocialApplicationInformation>, IDeepCloneable<SocialApplicationInformation>, IBufferMessage
{
	[Token(Token = "0x4002347")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SocialApplicationInformation> _parser;

	[Token(Token = "0x4002348")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002349")]
	public const int PlayerInformationFieldNumber = 1;

	[Token(Token = "0x400234A")]
	[FieldOffset(Offset = "0x18")]
	private CharacterInformation playerInformation_;

	[Token(Token = "0x400234B")]
	public const int ApplyTextFieldNumber = 2;

	[Token(Token = "0x400234C")]
	[FieldOffset(Offset = "0x20")]
	private string applyText_;

	[Token(Token = "0x400234D")]
	public const int CreationDateFieldNumber = 3;

	[Token(Token = "0x400234E")]
	[FieldOffset(Offset = "0x28")]
	private long creationDate_;

	[Token(Token = "0x17001632")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SocialApplicationInformation> Parser
	{
		[Token(Token = "0x6006770")]
		[Address(RVA = "0xBB0900", Offset = "0xBAFD00", VA = "0x180BB0900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001633")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006771")]
		[Address(RVA = "0xBB0850", Offset = "0xBAFC50", VA = "0x180BB0850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001634")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006772")]
		[Address(RVA = "0xBB0B50", Offset = "0xBAFF50", VA = "0x180BB0B50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001635")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterInformation PlayerInformation
	{
		[Token(Token = "0x6006776")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006777")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001636")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string ApplyText
	{
		[Token(Token = "0x6006778")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006779")]
		[Address(RVA = "0xBB0C30", Offset = "0xBB0030", VA = "0x180BB0C30")]
		set
		{
		}
	}

	[Token(Token = "0x17001637")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long CreationDate
	{
		[Token(Token = "0x600677A")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600677B")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x6006773")]
	[Address(RVA = "0xBB05F0", Offset = "0xBAF9F0", VA = "0x180BB05F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialApplicationInformation()
	{
	}

	[Token(Token = "0x6006774")]
	[Address(RVA = "0xBB0640", Offset = "0xBAFA40", VA = "0x180BB0640")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialApplicationInformation(SocialApplicationInformation other)
	{
	}

	[Token(Token = "0x6006775")]
	[Address(RVA = "0xBB0140", Offset = "0xBAF540", VA = "0x180BB0140", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialApplicationInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x600677C")]
	[Address(RVA = "0xBB01A0", Offset = "0xBAF5A0", VA = "0x180BB01A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600677D")]
	[Address(RVA = "0xBB0270", Offset = "0xBAF670", VA = "0x180BB0270", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SocialApplicationInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x600677E")]
	[Address(RVA = "0xBB02F0", Offset = "0xBAF6F0", VA = "0x180BB02F0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600677F")]
	[Address(RVA = "0xBB0490", Offset = "0xBAF890", VA = "0x180BB0490", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006780")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006781")]
	[Address(RVA = "0xBB0AA0", Offset = "0xBAFEA0", VA = "0x180BB0AA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006782")]
	[Address(RVA = "0xBB0050", Offset = "0xBAF450", VA = "0x180BB0050", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006783")]
	[Address(RVA = "0xBB03A0", Offset = "0xBAF7A0", VA = "0x180BB03A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SocialApplicationInformation other)
	{
	}

	[Token(Token = "0x6006784")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006785")]
	[Address(RVA = "0xBB0950", Offset = "0xBAFD50", VA = "0x180BB0950", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
