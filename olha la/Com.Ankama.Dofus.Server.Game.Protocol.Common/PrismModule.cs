using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AF8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PrismModule : IMessage<PrismModule>, IMessage, IEquatable<PrismModule>, IDeepCloneable<PrismModule>, IBufferMessage
{
	[Token(Token = "0x2000AF9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000AFA")]
		public enum PrismModuleType
		{
			[Token(Token = "0x4002888")]
			[OriginalName("NO_MODULE")]
			NoModule,
			[Token(Token = "0x4002889")]
			[OriginalName("TELEPORTER")]
			Teleporter,
			[Token(Token = "0x400288A")]
			[OriginalName("RECYCLER")]
			Recycler
		}
	}

	[Token(Token = "0x4002881")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PrismModule> _parser;

	[Token(Token = "0x4002882")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002883")]
	public const int ModuleObjectFieldNumber = 1;

	[Token(Token = "0x4002884")]
	[FieldOffset(Offset = "0x18")]
	private ObjectItemInventory moduleObject_;

	[Token(Token = "0x4002885")]
	public const int TypeFieldNumber = 2;

	[Token(Token = "0x4002886")]
	[FieldOffset(Offset = "0x20")]
	private Types.PrismModuleType type_;

	[Token(Token = "0x1700193F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PrismModule> Parser
	{
		[Token(Token = "0x600733E")]
		[Address(RVA = "0xBFED90", Offset = "0xBFE190", VA = "0x180BFED90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001940")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600733F")]
		[Address(RVA = "0xBFECE0", Offset = "0xBFE0E0", VA = "0x180BFECE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001941")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007340")]
		[Address(RVA = "0xBFEF00", Offset = "0xBFE300", VA = "0x180BFEF00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001942")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectItemInventory ModuleObject
	{
		[Token(Token = "0x6007344")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007345")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001943")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.PrismModuleType Type
	{
		[Token(Token = "0x6007346")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(Types.PrismModuleType);
		}
		[Token(Token = "0x6007347")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6007341")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismModule()
	{
	}

	[Token(Token = "0x6007342")]
	[Address(RVA = "0x98AF60", Offset = "0x98A360", VA = "0x18098AF60")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismModule(PrismModule other)
	{
	}

	[Token(Token = "0x6007343")]
	[Address(RVA = "0xBFE950", Offset = "0xBFDD50", VA = "0x180BFE950", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismModule Clone()
	{
		return null;
	}

	[Token(Token = "0x6007348")]
	[Address(RVA = "0xBFEA00", Offset = "0xBFDE00", VA = "0x180BFEA00", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007349")]
	[Address(RVA = "0x98AC30", Offset = "0x98A030", VA = "0x18098AC30", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PrismModule other)
	{
		return default(bool);
	}

	[Token(Token = "0x600734A")]
	[Address(RVA = "0x98ACA0", Offset = "0x98A0A0", VA = "0x18098ACA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600734B")]
	[Address(RVA = "0xBFEB80", Offset = "0xBFDF80", VA = "0x180BFEB80", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600734C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600734D")]
	[Address(RVA = "0x98B200", Offset = "0x98A600", VA = "0x18098B200", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600734E")]
	[Address(RVA = "0xBFE890", Offset = "0xBFDC90", VA = "0x180BFE890", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600734F")]
	[Address(RVA = "0xBFEAB0", Offset = "0xBFDEB0", VA = "0x180BFEAB0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PrismModule other)
	{
	}

	[Token(Token = "0x6007350")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007351")]
	[Address(RVA = "0xBFEDE0", Offset = "0xBFE1E0", VA = "0x180BFEDE0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
