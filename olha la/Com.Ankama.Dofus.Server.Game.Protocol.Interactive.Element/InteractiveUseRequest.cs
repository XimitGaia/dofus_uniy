using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Interactive.Element;

[Token(Token = "0x20003E0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class InteractiveUseRequest : IMessage<InteractiveUseRequest>, IMessage, IEquatable<InteractiveUseRequest>, IDeepCloneable<InteractiveUseRequest>, IBufferMessage
{
	[Token(Token = "0x4000D56")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<InteractiveUseRequest> _parser;

	[Token(Token = "0x4000D57")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D58")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4000D59")]
	public const int ElementIdFieldNumber = 1;

	[Token(Token = "0x4000D5A")]
	[FieldOffset(Offset = "0x1C")]
	private int elementId_;

	[Token(Token = "0x4000D5B")]
	public const int SkillInstanceUidFieldNumber = 2;

	[Token(Token = "0x4000D5C")]
	[FieldOffset(Offset = "0x20")]
	private int skillInstanceUid_;

	[Token(Token = "0x4000D5D")]
	public const int SpecificInstanceIdFieldNumber = 3;

	[Token(Token = "0x4000D5E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int SpecificInstanceIdDefaultValue;

	[Token(Token = "0x4000D5F")]
	[FieldOffset(Offset = "0x24")]
	private int specificInstanceId_;

	[Token(Token = "0x170008A8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<InteractiveUseRequest> Parser
	{
		[Token(Token = "0x6002885")]
		[Address(RVA = "0x9A7400", Offset = "0x9A6800", VA = "0x1809A7400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008A9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002886")]
		[Address(RVA = "0x9A7350", Offset = "0x9A6750", VA = "0x1809A7350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008AA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002887")]
		[Address(RVA = "0x9A75A0", Offset = "0x9A69A0", VA = "0x1809A75A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008AB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ElementId
	{
		[Token(Token = "0x600288B")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600288C")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170008AC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SkillInstanceUid
	{
		[Token(Token = "0x600288D")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600288E")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x170008AD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SpecificInstanceId
	{
		[Token(Token = "0x600288F")]
		[Address(RVA = "0x9A7450", Offset = "0x9A6850", VA = "0x1809A7450")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002890")]
		[Address(RVA = "0x945AB0", Offset = "0x944EB0", VA = "0x180945AB0")]
		set
		{
		}
	}

	[Token(Token = "0x170008AE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasSpecificInstanceId
	{
		[Token(Token = "0x6002891")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002888")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractiveUseRequest()
	{
	}

	[Token(Token = "0x6002889")]
	[Address(RVA = "0x945650", Offset = "0x944A50", VA = "0x180945650")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InteractiveUseRequest(InteractiveUseRequest other)
	{
	}

	[Token(Token = "0x600288A")]
	[Address(RVA = "0x9A6EB0", Offset = "0x9A62B0", VA = "0x1809A6EB0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InteractiveUseRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002892")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearSpecificInstanceId()
	{
	}

	[Token(Token = "0x6002893")]
	[Address(RVA = "0x9A6F40", Offset = "0x9A6340", VA = "0x1809A6F40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002894")]
	[Address(RVA = "0x9A7000", Offset = "0x9A6400", VA = "0x1809A7000", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(InteractiveUseRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002895")]
	[Address(RVA = "0x9A7080", Offset = "0x9A6480", VA = "0x1809A7080", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002896")]
	[Address(RVA = "0x9A71E0", Offset = "0x9A65E0", VA = "0x1809A71E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002897")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002898")]
	[Address(RVA = "0x9A74C0", Offset = "0x9A68C0", VA = "0x1809A74C0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002899")]
	[Address(RVA = "0x9A6D80", Offset = "0x9A6180", VA = "0x1809A6D80", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600289A")]
	[Address(RVA = "0x9A7170", Offset = "0x9A6570", VA = "0x1809A7170", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(InteractiveUseRequest other)
	{
	}

	[Token(Token = "0x600289B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600289C")]
	[Address(RVA = "0x945820", Offset = "0x944C20", VA = "0x180945820", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
