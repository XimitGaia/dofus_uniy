using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CDF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceFightsInformationEvent : IMessage<AllianceFightsInformationEvent>, IMessage, IEquatable<AllianceFightsInformationEvent>, IDeepCloneable<AllianceFightsInformationEvent>, IBufferMessage
{
	[Token(Token = "0x4002F5F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceFightsInformationEvent> _parser;

	[Token(Token = "0x4002F60")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F61")]
	public const int AllianceFightsFieldNumber = 1;

	[Token(Token = "0x4002F62")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<SocialFight> _repeated_allianceFights_codec;

	[Token(Token = "0x4002F63")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<SocialFight> allianceFights_;

	[Token(Token = "0x17001DA6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceFightsInformationEvent> Parser
	{
		[Token(Token = "0x60087A4")]
		[Address(RVA = "0xCAEAA0", Offset = "0xCADEA0", VA = "0x180CAEAA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DA7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60087A5")]
		[Address(RVA = "0xCAE9F0", Offset = "0xCADDF0", VA = "0x180CAE9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DA8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60087A6")]
		[Address(RVA = "0xCAECB0", Offset = "0xCAE0B0", VA = "0x180CAECB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DA9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<SocialFight> AllianceFights
	{
		[Token(Token = "0x60087AA")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60087A7")]
	[Address(RVA = "0xCAE8E0", Offset = "0xCADCE0", VA = "0x180CAE8E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFightsInformationEvent()
	{
	}

	[Token(Token = "0x60087A8")]
	[Address(RVA = "0xCAE960", Offset = "0xCADD60", VA = "0x180CAE960")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFightsInformationEvent(AllianceFightsInformationEvent other)
	{
	}

	[Token(Token = "0x60087A9")]
	[Address(RVA = "0xCAE430", Offset = "0xCAD830", VA = "0x180CAE430", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFightsInformationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60087AB")]
	[Address(RVA = "0xCAE580", Offset = "0xCAD980", VA = "0x180CAE580", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60087AC")]
	[Address(RVA = "0xCAE4F0", Offset = "0xCAD8F0", VA = "0x180CAE4F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceFightsInformationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60087AD")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60087AE")]
	[Address(RVA = "0xCAE6E0", Offset = "0xCADAE0", VA = "0x180CAE6E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60087AF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60087B0")]
	[Address(RVA = "0xCAEC00", Offset = "0xCAE000", VA = "0x180CAEC00", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60087B1")]
	[Address(RVA = "0xCAE390", Offset = "0xCAD790", VA = "0x180CAE390", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60087B2")]
	[Address(RVA = "0xCAE660", Offset = "0xCADA60", VA = "0x180CAE660", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceFightsInformationEvent other)
	{
	}

	[Token(Token = "0x60087B3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60087B4")]
	[Address(RVA = "0xCAEAF0", Offset = "0xCADEF0", VA = "0x180CAEAF0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
